using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FE9 RID: 4073
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournLeaveScRsp : IMessage<RogueTournLeaveScRsp>, IMessage, IEquatable<RogueTournLeaveScRsp>, IDeepCloneable<RogueTournLeaveScRsp>, IBufferMessage
	{
		// Token: 0x17003316 RID: 13078
		// (get) Token: 0x0600B547 RID: 46407 RVA: 0x001E68EB File Offset: 0x001E4AEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournLeaveScRsp> Parser
		{
			get
			{
				return RogueTournLeaveScRsp._parser;
			}
		}

		// Token: 0x17003317 RID: 13079
		// (get) Token: 0x0600B548 RID: 46408 RVA: 0x001E68F2 File Offset: 0x001E4AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournLeaveScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003318 RID: 13080
		// (get) Token: 0x0600B549 RID: 46409 RVA: 0x001E6904 File Offset: 0x001E4B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournLeaveScRsp.Descriptor;
			}
		}

		// Token: 0x0600B54A RID: 46410 RVA: 0x001E690B File Offset: 0x001E4B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLeaveScRsp()
		{
		}

		// Token: 0x0600B54B RID: 46411 RVA: 0x001E6914 File Offset: 0x001E4B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLeaveScRsp(RogueTournLeaveScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B54C RID: 46412 RVA: 0x001E6960 File Offset: 0x001E4B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLeaveScRsp Clone()
		{
			return new RogueTournLeaveScRsp(this);
		}

		// Token: 0x17003319 RID: 13081
		// (get) Token: 0x0600B54D RID: 46413 RVA: 0x001E6968 File Offset: 0x001E4B68
		// (set) Token: 0x0600B54E RID: 46414 RVA: 0x001E6970 File Offset: 0x001E4B70
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

		// Token: 0x1700331A RID: 13082
		// (get) Token: 0x0600B54F RID: 46415 RVA: 0x001E6979 File Offset: 0x001E4B79
		// (set) Token: 0x0600B550 RID: 46416 RVA: 0x001E6981 File Offset: 0x001E4B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurSceneInfo RogueTournCurSceneInfo
		{
			get
			{
				return this.rogueTournCurSceneInfo_;
			}
			set
			{
				this.rogueTournCurSceneInfo_ = value;
			}
		}

		// Token: 0x0600B551 RID: 46417 RVA: 0x001E698A File Offset: 0x001E4B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournLeaveScRsp);
		}

		// Token: 0x0600B552 RID: 46418 RVA: 0x001E6998 File Offset: 0x001E4B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournLeaveScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B553 RID: 46419 RVA: 0x001E69E8 File Offset: 0x001E4BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num ^= this.RogueTournCurSceneInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B554 RID: 46420 RVA: 0x001E6A3D File Offset: 0x001E4C3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B555 RID: 46421 RVA: 0x001E6A45 File Offset: 0x001E4C45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B556 RID: 46422 RVA: 0x001E6A50 File Offset: 0x001E4C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RogueTournCurSceneInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B557 RID: 46423 RVA: 0x001E6AA8 File Offset: 0x001E4CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurSceneInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B558 RID: 46424 RVA: 0x001E6B00 File Offset: 0x001E4D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournLeaveScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.rogueTournCurSceneInfo_ != null)
			{
				if (this.rogueTournCurSceneInfo_ == null)
				{
					this.RogueTournCurSceneInfo = new RogueTournCurSceneInfo();
				}
				this.RogueTournCurSceneInfo.MergeFrom(other.RogueTournCurSceneInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B559 RID: 46425 RVA: 0x001E6B68 File Offset: 0x001E4D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B55A RID: 46426 RVA: 0x001E6B74 File Offset: 0x001E4D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueTournCurSceneInfo_ == null)
						{
							this.RogueTournCurSceneInfo = new RogueTournCurSceneInfo();
						}
						input.ReadMessage(this.RogueTournCurSceneInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004983 RID: 18819
		private static readonly MessageParser<RogueTournLeaveScRsp> _parser = new MessageParser<RogueTournLeaveScRsp>(() => new RogueTournLeaveScRsp());

		// Token: 0x04004984 RID: 18820
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004985 RID: 18821
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04004986 RID: 18822
		private uint retcode_;

		// Token: 0x04004987 RID: 18823
		public const int RogueTournCurSceneInfoFieldNumber = 14;

		// Token: 0x04004988 RID: 18824
		private RogueTournCurSceneInfo rogueTournCurSceneInfo_;
	}
}
