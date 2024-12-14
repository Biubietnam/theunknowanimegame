using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200085B RID: 2139
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GHHNONNKCKJ : IMessage<GHHNONNKCKJ>, IMessage, IEquatable<GHHNONNKCKJ>, IDeepCloneable<GHHNONNKCKJ>, IBufferMessage
	{
		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x06005F20 RID: 24352 RVA: 0x000FBC69 File Offset: 0x000F9E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GHHNONNKCKJ> Parser
		{
			get
			{
				return GHHNONNKCKJ._parser;
			}
		}

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x06005F21 RID: 24353 RVA: 0x000FBC70 File Offset: 0x000F9E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GHHNONNKCKJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x06005F22 RID: 24354 RVA: 0x000FBC82 File Offset: 0x000F9E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GHHNONNKCKJ.Descriptor;
			}
		}

		// Token: 0x06005F23 RID: 24355 RVA: 0x000FBC89 File Offset: 0x000F9E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GHHNONNKCKJ()
		{
		}

		// Token: 0x06005F24 RID: 24356 RVA: 0x000FBC94 File Offset: 0x000F9E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GHHNONNKCKJ(GHHNONNKCKJ other) : this()
		{
			this.eHMEAGKBIID_ = other.eHMEAGKBIID_;
			this.mMLBFPNPHCL_ = other.mMLBFPNPHCL_;
			this.oPOOCGFLAOH_ = other.oPOOCGFLAOH_;
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F25 RID: 24357 RVA: 0x000FBCE8 File Offset: 0x000F9EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GHHNONNKCKJ Clone()
		{
			return new GHHNONNKCKJ(this);
		}

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x06005F26 RID: 24358 RVA: 0x000FBCF0 File Offset: 0x000F9EF0
		// (set) Token: 0x06005F27 RID: 24359 RVA: 0x000FBCF8 File Offset: 0x000F9EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EHMEAGKBIID
		{
			get
			{
				return this.eHMEAGKBIID_;
			}
			set
			{
				this.eHMEAGKBIID_ = value;
			}
		}

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x06005F28 RID: 24360 RVA: 0x000FBD01 File Offset: 0x000F9F01
		// (set) Token: 0x06005F29 RID: 24361 RVA: 0x000FBD09 File Offset: 0x000F9F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MMLBFPNPHCL
		{
			get
			{
				return this.mMLBFPNPHCL_;
			}
			set
			{
				this.mMLBFPNPHCL_ = value;
			}
		}

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x06005F2A RID: 24362 RVA: 0x000FBD12 File Offset: 0x000F9F12
		// (set) Token: 0x06005F2B RID: 24363 RVA: 0x000FBD1A File Offset: 0x000F9F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OPOOCGFLAOH
		{
			get
			{
				return this.oPOOCGFLAOH_;
			}
			set
			{
				this.oPOOCGFLAOH_ = value;
			}
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x06005F2C RID: 24364 RVA: 0x000FBD23 File Offset: 0x000F9F23
		// (set) Token: 0x06005F2D RID: 24365 RVA: 0x000FBD2B File Offset: 0x000F9F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x000FBD34 File Offset: 0x000F9F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GHHNONNKCKJ);
		}

		// Token: 0x06005F2F RID: 24367 RVA: 0x000FBD44 File Offset: 0x000F9F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GHHNONNKCKJ other)
		{
			return other != null && (other == this || (this.EHMEAGKBIID == other.EHMEAGKBIID && this.MMLBFPNPHCL == other.MMLBFPNPHCL && this.OPOOCGFLAOH == other.OPOOCGFLAOH && this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F30 RID: 24368 RVA: 0x000FBDB0 File Offset: 0x000F9FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EHMEAGKBIID != 0U)
			{
				num ^= this.EHMEAGKBIID.GetHashCode();
			}
			if (this.MMLBFPNPHCL != 0U)
			{
				num ^= this.MMLBFPNPHCL.GetHashCode();
			}
			if (this.OPOOCGFLAOH != 0U)
			{
				num ^= this.OPOOCGFLAOH.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005F31 RID: 24369 RVA: 0x000FBE3A File Offset: 0x000FA03A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005F32 RID: 24370 RVA: 0x000FBE42 File Offset: 0x000FA042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F33 RID: 24371 RVA: 0x000FBE4C File Offset: 0x000FA04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GroupId);
			}
			if (this.OPOOCGFLAOH != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.OPOOCGFLAOH);
			}
			if (this.EHMEAGKBIID != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.EHMEAGKBIID);
			}
			if (this.MMLBFPNPHCL != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.MMLBFPNPHCL);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F34 RID: 24372 RVA: 0x000FBEDC File Offset: 0x000FA0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EHMEAGKBIID != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EHMEAGKBIID);
			}
			if (this.MMLBFPNPHCL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MMLBFPNPHCL);
			}
			if (this.OPOOCGFLAOH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OPOOCGFLAOH);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005F35 RID: 24373 RVA: 0x000FBF64 File Offset: 0x000FA164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GHHNONNKCKJ other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EHMEAGKBIID != 0U)
			{
				this.EHMEAGKBIID = other.EHMEAGKBIID;
			}
			if (other.MMLBFPNPHCL != 0U)
			{
				this.MMLBFPNPHCL = other.MMLBFPNPHCL;
			}
			if (other.OPOOCGFLAOH != 0U)
			{
				this.OPOOCGFLAOH = other.OPOOCGFLAOH;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005F36 RID: 24374 RVA: 0x000FBFDC File Offset: 0x000FA1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F37 RID: 24375 RVA: 0x000FBFE8 File Offset: 0x000FA1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 8U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.OPOOCGFLAOH = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.EHMEAGKBIID = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.MMLBFPNPHCL = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400249D RID: 9373
		private static readonly MessageParser<GHHNONNKCKJ> _parser = new MessageParser<GHHNONNKCKJ>(() => new GHHNONNKCKJ());

		// Token: 0x0400249E RID: 9374
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400249F RID: 9375
		public const int EHMEAGKBIIDFieldNumber = 8;

		// Token: 0x040024A0 RID: 9376
		private uint eHMEAGKBIID_;

		// Token: 0x040024A1 RID: 9377
		public const int MMLBFPNPHCLFieldNumber = 9;

		// Token: 0x040024A2 RID: 9378
		private uint mMLBFPNPHCL_;

		// Token: 0x040024A3 RID: 9379
		public const int OPOOCGFLAOHFieldNumber = 6;

		// Token: 0x040024A4 RID: 9380
		private uint oPOOCGFLAOH_;

		// Token: 0x040024A5 RID: 9381
		public const int GroupIdFieldNumber = 1;

		// Token: 0x040024A6 RID: 9382
		private uint groupId_;
	}
}
