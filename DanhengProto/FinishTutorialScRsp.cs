using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005A5 RID: 1445
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishTutorialScRsp : IMessage<FinishTutorialScRsp>, IMessage, IEquatable<FinishTutorialScRsp>, IDeepCloneable<FinishTutorialScRsp>, IBufferMessage
	{
		// Token: 0x17001253 RID: 4691
		// (get) Token: 0x0600407E RID: 16510 RVA: 0x000AF9E1 File Offset: 0x000ADBE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishTutorialScRsp> Parser
		{
			get
			{
				return FinishTutorialScRsp._parser;
			}
		}

		// Token: 0x17001254 RID: 4692
		// (get) Token: 0x0600407F RID: 16511 RVA: 0x000AF9E8 File Offset: 0x000ADBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishTutorialScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x06004080 RID: 16512 RVA: 0x000AF9FA File Offset: 0x000ADBFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishTutorialScRsp.Descriptor;
			}
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x000AFA01 File Offset: 0x000ADC01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTutorialScRsp()
		{
		}

		// Token: 0x06004082 RID: 16514 RVA: 0x000AFA0C File Offset: 0x000ADC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTutorialScRsp(FinishTutorialScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.tutorial_ = ((other.tutorial_ != null) ? other.tutorial_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004083 RID: 16515 RVA: 0x000AFA58 File Offset: 0x000ADC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTutorialScRsp Clone()
		{
			return new FinishTutorialScRsp(this);
		}

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x06004084 RID: 16516 RVA: 0x000AFA60 File Offset: 0x000ADC60
		// (set) Token: 0x06004085 RID: 16517 RVA: 0x000AFA68 File Offset: 0x000ADC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x06004086 RID: 16518 RVA: 0x000AFA71 File Offset: 0x000ADC71
		// (set) Token: 0x06004087 RID: 16519 RVA: 0x000AFA79 File Offset: 0x000ADC79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Tutorial Tutorial
		{
			get
			{
				return this.tutorial_;
			}
			set
			{
				this.tutorial_ = value;
			}
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x000AFA82 File Offset: 0x000ADC82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishTutorialScRsp);
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x000AFA90 File Offset: 0x000ADC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishTutorialScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.Tutorial, other.Tutorial) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x000AFAE0 File Offset: 0x000ADCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.tutorial_ != null)
			{
				num ^= this.Tutorial.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x000AFB35 File Offset: 0x000ADD35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x000AFB3D File Offset: 0x000ADD3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x000AFB48 File Offset: 0x000ADD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.tutorial_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Tutorial);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x000AFBA4 File Offset: 0x000ADDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.tutorial_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Tutorial);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x000AFBFC File Offset: 0x000ADDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishTutorialScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.tutorial_ != null)
			{
				if (this.tutorial_ == null)
				{
					this.Tutorial = new Tutorial();
				}
				this.Tutorial.MergeFrom(other.Tutorial);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x000AFC64 File Offset: 0x000ADE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x000AFC70 File Offset: 0x000ADE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.tutorial_ == null)
					{
						this.Tutorial = new Tutorial();
					}
					input.ReadMessage(this.Tutorial);
				}
			}
		}

		// Token: 0x04001997 RID: 6551
		private static readonly MessageParser<FinishTutorialScRsp> _parser = new MessageParser<FinishTutorialScRsp>(() => new FinishTutorialScRsp());

		// Token: 0x04001998 RID: 6552
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001999 RID: 6553
		public const int RetcodeFieldNumber = 14;

		// Token: 0x0400199A RID: 6554
		private uint retcode_;

		// Token: 0x0400199B RID: 6555
		public const int TutorialFieldNumber = 3;

		// Token: 0x0400199C RID: 6556
		private Tutorial tutorial_;
	}
}
