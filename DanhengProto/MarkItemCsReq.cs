using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A89 RID: 2697
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MarkItemCsReq : IMessage<MarkItemCsReq>, IMessage, IEquatable<MarkItemCsReq>, IDeepCloneable<MarkItemCsReq>, IBufferMessage
	{
		// Token: 0x17002193 RID: 8595
		// (get) Token: 0x06007790 RID: 30608 RVA: 0x0013D1A0 File Offset: 0x0013B3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MarkItemCsReq> Parser
		{
			get
			{
				return MarkItemCsReq._parser;
			}
		}

		// Token: 0x17002194 RID: 8596
		// (get) Token: 0x06007791 RID: 30609 RVA: 0x0013D1A7 File Offset: 0x0013B3A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MarkItemCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002195 RID: 8597
		// (get) Token: 0x06007792 RID: 30610 RVA: 0x0013D1B9 File Offset: 0x0013B3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkItemCsReq.Descriptor;
			}
		}

		// Token: 0x06007793 RID: 30611 RVA: 0x0013D1C0 File Offset: 0x0013B3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkItemCsReq()
		{
		}

		// Token: 0x06007794 RID: 30612 RVA: 0x0013D1C8 File Offset: 0x0013B3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkItemCsReq(MarkItemCsReq other) : this()
		{
			this.itemId_ = other.itemId_;
			this.fBEHICBKCAM_ = other.fBEHICBKCAM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007795 RID: 30613 RVA: 0x0013D1F9 File Offset: 0x0013B3F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkItemCsReq Clone()
		{
			return new MarkItemCsReq(this);
		}

		// Token: 0x17002196 RID: 8598
		// (get) Token: 0x06007796 RID: 30614 RVA: 0x0013D201 File Offset: 0x0013B401
		// (set) Token: 0x06007797 RID: 30615 RVA: 0x0013D209 File Offset: 0x0013B409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17002197 RID: 8599
		// (get) Token: 0x06007798 RID: 30616 RVA: 0x0013D212 File Offset: 0x0013B412
		// (set) Token: 0x06007799 RID: 30617 RVA: 0x0013D21A File Offset: 0x0013B41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FBEHICBKCAM
		{
			get
			{
				return this.fBEHICBKCAM_;
			}
			set
			{
				this.fBEHICBKCAM_ = value;
			}
		}

		// Token: 0x0600779A RID: 30618 RVA: 0x0013D223 File Offset: 0x0013B423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkItemCsReq);
		}

		// Token: 0x0600779B RID: 30619 RVA: 0x0013D231 File Offset: 0x0013B431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MarkItemCsReq other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.FBEHICBKCAM == other.FBEHICBKCAM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600779C RID: 30620 RVA: 0x0013D270 File Offset: 0x0013B470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.FBEHICBKCAM)
			{
				num ^= this.FBEHICBKCAM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600779D RID: 30621 RVA: 0x0013D2C8 File Offset: 0x0013B4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600779E RID: 30622 RVA: 0x0013D2D0 File Offset: 0x0013B4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600779F RID: 30623 RVA: 0x0013D2DC File Offset: 0x0013B4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ItemId);
			}
			if (this.FBEHICBKCAM)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.FBEHICBKCAM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060077A0 RID: 30624 RVA: 0x0013D338 File Offset: 0x0013B538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.FBEHICBKCAM)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060077A1 RID: 30625 RVA: 0x0013D384 File Offset: 0x0013B584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MarkItemCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.FBEHICBKCAM)
			{
				this.FBEHICBKCAM = other.FBEHICBKCAM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060077A2 RID: 30626 RVA: 0x0013D3D4 File Offset: 0x0013B5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060077A3 RID: 30627 RVA: 0x0013D3E0 File Offset: 0x0013B5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FBEHICBKCAM = input.ReadBool();
					}
				}
				else
				{
					this.ItemId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002DE8 RID: 11752
		private static readonly MessageParser<MarkItemCsReq> _parser = new MessageParser<MarkItemCsReq>(() => new MarkItemCsReq());

		// Token: 0x04002DE9 RID: 11753
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DEA RID: 11754
		public const int ItemIdFieldNumber = 8;

		// Token: 0x04002DEB RID: 11755
		private uint itemId_;

		// Token: 0x04002DEC RID: 11756
		public const int FBEHICBKCAMFieldNumber = 9;

		// Token: 0x04002DED RID: 11757
		private bool fBEHICBKCAM_;
	}
}
