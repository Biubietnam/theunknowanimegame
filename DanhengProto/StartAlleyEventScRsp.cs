using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200119B RID: 4507
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartAlleyEventScRsp : IMessage<StartAlleyEventScRsp>, IMessage, IEquatable<StartAlleyEventScRsp>, IDeepCloneable<StartAlleyEventScRsp>, IBufferMessage
	{
		// Token: 0x170038BC RID: 14524
		// (get) Token: 0x0600C92F RID: 51503 RVA: 0x0021BA5C File Offset: 0x00219C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartAlleyEventScRsp> Parser
		{
			get
			{
				return StartAlleyEventScRsp._parser;
			}
		}

		// Token: 0x170038BD RID: 14525
		// (get) Token: 0x0600C930 RID: 51504 RVA: 0x0021BA63 File Offset: 0x00219C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartAlleyEventScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170038BE RID: 14526
		// (get) Token: 0x0600C931 RID: 51505 RVA: 0x0021BA75 File Offset: 0x00219C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartAlleyEventScRsp.Descriptor;
			}
		}

		// Token: 0x0600C932 RID: 51506 RVA: 0x0021BA7C File Offset: 0x00219C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAlleyEventScRsp()
		{
		}

		// Token: 0x0600C933 RID: 51507 RVA: 0x0021BA84 File Offset: 0x00219C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAlleyEventScRsp(StartAlleyEventScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C934 RID: 51508 RVA: 0x0021BAB5 File Offset: 0x00219CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartAlleyEventScRsp Clone()
		{
			return new StartAlleyEventScRsp(this);
		}

		// Token: 0x170038BF RID: 14527
		// (get) Token: 0x0600C935 RID: 51509 RVA: 0x0021BABD File Offset: 0x00219CBD
		// (set) Token: 0x0600C936 RID: 51510 RVA: 0x0021BAC5 File Offset: 0x00219CC5
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

		// Token: 0x170038C0 RID: 14528
		// (get) Token: 0x0600C937 RID: 51511 RVA: 0x0021BACE File Offset: 0x00219CCE
		// (set) Token: 0x0600C938 RID: 51512 RVA: 0x0021BAD6 File Offset: 0x00219CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x0600C939 RID: 51513 RVA: 0x0021BADF File Offset: 0x00219CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartAlleyEventScRsp);
		}

		// Token: 0x0600C93A RID: 51514 RVA: 0x0021BAED File Offset: 0x00219CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartAlleyEventScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C93B RID: 51515 RVA: 0x0021BB2C File Offset: 0x00219D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C93C RID: 51516 RVA: 0x0021BB84 File Offset: 0x00219D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C93D RID: 51517 RVA: 0x0021BB8C File Offset: 0x00219D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C93E RID: 51518 RVA: 0x0021BB98 File Offset: 0x00219D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this.EventId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.EventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C93F RID: 51519 RVA: 0x0021BBF4 File Offset: 0x00219DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C940 RID: 51520 RVA: 0x0021BC4C File Offset: 0x00219E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartAlleyEventScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C941 RID: 51521 RVA: 0x0021BC9C File Offset: 0x00219E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C942 RID: 51522 RVA: 0x0021BCA8 File Offset: 0x00219EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EventId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400512B RID: 20779
		private static readonly MessageParser<StartAlleyEventScRsp> _parser = new MessageParser<StartAlleyEventScRsp>(() => new StartAlleyEventScRsp());

		// Token: 0x0400512C RID: 20780
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400512D RID: 20781
		public const int RetcodeFieldNumber = 7;

		// Token: 0x0400512E RID: 20782
		private uint retcode_;

		// Token: 0x0400512F RID: 20783
		public const int EventIdFieldNumber = 14;

		// Token: 0x04005130 RID: 20784
		private uint eventId_;
	}
}
