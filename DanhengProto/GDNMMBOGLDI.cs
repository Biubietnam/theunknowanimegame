using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005F1 RID: 1521
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GDNMMBOGLDI : IMessage<GDNMMBOGLDI>, IMessage, IEquatable<GDNMMBOGLDI>, IDeepCloneable<GDNMMBOGLDI>, IBufferMessage
	{
		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x06004450 RID: 17488 RVA: 0x000BB994 File Offset: 0x000B9B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GDNMMBOGLDI> Parser
		{
			get
			{
				return GDNMMBOGLDI._parser;
			}
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06004451 RID: 17489 RVA: 0x000BB99B File Offset: 0x000B9B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GDNMMBOGLDIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x06004452 RID: 17490 RVA: 0x000BB9AD File Offset: 0x000B9BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GDNMMBOGLDI.Descriptor;
			}
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x000BB9B4 File Offset: 0x000B9BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GDNMMBOGLDI()
		{
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x000BB9BC File Offset: 0x000B9BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GDNMMBOGLDI(GDNMMBOGLDI other) : this()
		{
			this.dBFBFMPPFMK_ = other.dBFBFMPPFMK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x000BB9E1 File Offset: 0x000B9BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GDNMMBOGLDI Clone()
		{
			return new GDNMMBOGLDI(this);
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x06004456 RID: 17494 RVA: 0x000BB9E9 File Offset: 0x000B9BE9
		// (set) Token: 0x06004457 RID: 17495 RVA: 0x000BB9F1 File Offset: 0x000B9BF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DBFBFMPPFMK
		{
			get
			{
				return this.dBFBFMPPFMK_;
			}
			set
			{
				this.dBFBFMPPFMK_ = value;
			}
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x000BB9FA File Offset: 0x000B9BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GDNMMBOGLDI);
		}

		// Token: 0x06004459 RID: 17497 RVA: 0x000BBA08 File Offset: 0x000B9C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GDNMMBOGLDI other)
		{
			return other != null && (other == this || (this.DBFBFMPPFMK == other.DBFBFMPPFMK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x000BBA38 File Offset: 0x000B9C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DBFBFMPPFMK != 0U)
			{
				num ^= this.DBFBFMPPFMK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x000BBA77 File Offset: 0x000B9C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x000BBA7F File Offset: 0x000B9C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x000BBA88 File Offset: 0x000B9C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DBFBFMPPFMK != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.DBFBFMPPFMK);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600445E RID: 17502 RVA: 0x000BBABC File Offset: 0x000B9CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DBFBFMPPFMK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DBFBFMPPFMK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600445F RID: 17503 RVA: 0x000BBAFA File Offset: 0x000B9CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GDNMMBOGLDI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DBFBFMPPFMK != 0U)
			{
				this.DBFBFMPPFMK = other.DBFBFMPPFMK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x000BBB2B File Offset: 0x000B9D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x000BBB34 File Offset: 0x000B9D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DBFBFMPPFMK = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001B5C RID: 7004
		private static readonly MessageParser<GDNMMBOGLDI> _parser = new MessageParser<GDNMMBOGLDI>(() => new GDNMMBOGLDI());

		// Token: 0x04001B5D RID: 7005
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001B5E RID: 7006
		public const int DBFBFMPPFMKFieldNumber = 14;

		// Token: 0x04001B5F RID: 7007
		private uint dBFBFMPPFMK_;
	}
}
