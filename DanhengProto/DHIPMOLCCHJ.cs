using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000397 RID: 919
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DHIPMOLCCHJ : IMessage<DHIPMOLCCHJ>, IMessage, IEquatable<DHIPMOLCCHJ>, IDeepCloneable<DHIPMOLCCHJ>, IBufferMessage
	{
		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x060028D2 RID: 10450 RVA: 0x0007188C File Offset: 0x0006FA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DHIPMOLCCHJ> Parser
		{
			get
			{
				return DHIPMOLCCHJ._parser;
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x060028D3 RID: 10451 RVA: 0x00071893 File Offset: 0x0006FA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DHIPMOLCCHJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x060028D4 RID: 10452 RVA: 0x000718A5 File Offset: 0x0006FAA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DHIPMOLCCHJ.Descriptor;
			}
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x000718AC File Offset: 0x0006FAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DHIPMOLCCHJ()
		{
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x000718B4 File Offset: 0x0006FAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DHIPMOLCCHJ(DHIPMOLCCHJ other) : this()
		{
			this.cBACGCAGBBB_ = other.cBACGCAGBBB_;
			this.progress_ = other.progress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x000718E5 File Offset: 0x0006FAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DHIPMOLCCHJ Clone()
		{
			return new DHIPMOLCCHJ(this);
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x060028D8 RID: 10456 RVA: 0x000718ED File Offset: 0x0006FAED
		// (set) Token: 0x060028D9 RID: 10457 RVA: 0x000718F5 File Offset: 0x0006FAF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CBACGCAGBBB
		{
			get
			{
				return this.cBACGCAGBBB_;
			}
			set
			{
				this.cBACGCAGBBB_ = value;
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x060028DA RID: 10458 RVA: 0x000718FE File Offset: 0x0006FAFE
		// (set) Token: 0x060028DB RID: 10459 RVA: 0x00071906 File Offset: 0x0006FB06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x0007190F File Offset: 0x0006FB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DHIPMOLCCHJ);
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x0007191D File Offset: 0x0006FB1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DHIPMOLCCHJ other)
		{
			return other != null && (other == this || (this.CBACGCAGBBB == other.CBACGCAGBBB && this.Progress == other.Progress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x0007195C File Offset: 0x0006FB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CBACGCAGBBB != 0U)
			{
				num ^= this.CBACGCAGBBB.GetHashCode();
			}
			if (this.Progress != 0U)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x000719B4 File Offset: 0x0006FBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x000719BC File Offset: 0x0006FBBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x000719C8 File Offset: 0x0006FBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Progress != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Progress);
			}
			if (this.CBACGCAGBBB != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CBACGCAGBBB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x00071A24 File Offset: 0x0006FC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CBACGCAGBBB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CBACGCAGBBB);
			}
			if (this.Progress != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Progress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x00071A7C File Offset: 0x0006FC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DHIPMOLCCHJ other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CBACGCAGBBB != 0U)
			{
				this.CBACGCAGBBB = other.CBACGCAGBBB;
			}
			if (other.Progress != 0U)
			{
				this.Progress = other.Progress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060028E4 RID: 10468 RVA: 0x00071ACC File Offset: 0x0006FCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x00071AD8 File Offset: 0x0006FCD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CBACGCAGBBB = input.ReadUInt32();
					}
				}
				else
				{
					this.Progress = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001076 RID: 4214
		private static readonly MessageParser<DHIPMOLCCHJ> _parser = new MessageParser<DHIPMOLCCHJ>(() => new DHIPMOLCCHJ());

		// Token: 0x04001077 RID: 4215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001078 RID: 4216
		public const int CBACGCAGBBBFieldNumber = 6;

		// Token: 0x04001079 RID: 4217
		private uint cBACGCAGBBB_;

		// Token: 0x0400107A RID: 4218
		public const int ProgressFieldNumber = 3;

		// Token: 0x0400107B RID: 4219
		private uint progress_;
	}
}
