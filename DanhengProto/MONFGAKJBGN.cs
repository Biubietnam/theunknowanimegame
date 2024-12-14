using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B01 RID: 2817
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MONFGAKJBGN : IMessage<MONFGAKJBGN>, IMessage, IEquatable<MONFGAKJBGN>, IDeepCloneable<MONFGAKJBGN>, IBufferMessage
	{
		// Token: 0x17002302 RID: 8962
		// (get) Token: 0x06007CAB RID: 31915 RVA: 0x0014A2B4 File Offset: 0x001484B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MONFGAKJBGN> Parser
		{
			get
			{
				return MONFGAKJBGN._parser;
			}
		}

		// Token: 0x17002303 RID: 8963
		// (get) Token: 0x06007CAC RID: 31916 RVA: 0x0014A2BB File Offset: 0x001484BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MONFGAKJBGNReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002304 RID: 8964
		// (get) Token: 0x06007CAD RID: 31917 RVA: 0x0014A2CD File Offset: 0x001484CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MONFGAKJBGN.Descriptor;
			}
		}

		// Token: 0x06007CAE RID: 31918 RVA: 0x0014A2D4 File Offset: 0x001484D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MONFGAKJBGN()
		{
		}

		// Token: 0x06007CAF RID: 31919 RVA: 0x0014A2DC File Offset: 0x001484DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MONFGAKJBGN(MONFGAKJBGN other) : this()
		{
			this.dFEBKIGAJGJ_ = other.dFEBKIGAJGJ_;
			this.cGAAJPDAFMG_ = other.cGAAJPDAFMG_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007CB0 RID: 31920 RVA: 0x0014A319 File Offset: 0x00148519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MONFGAKJBGN Clone()
		{
			return new MONFGAKJBGN(this);
		}

		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x06007CB1 RID: 31921 RVA: 0x0014A321 File Offset: 0x00148521
		// (set) Token: 0x06007CB2 RID: 31922 RVA: 0x0014A329 File Offset: 0x00148529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DFEBKIGAJGJ
		{
			get
			{
				return this.dFEBKIGAJGJ_;
			}
			set
			{
				this.dFEBKIGAJGJ_ = value;
			}
		}

		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x06007CB3 RID: 31923 RVA: 0x0014A332 File Offset: 0x00148532
		// (set) Token: 0x06007CB4 RID: 31924 RVA: 0x0014A33A File Offset: 0x0014853A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CGAAJPDAFMG
		{
			get
			{
				return this.cGAAJPDAFMG_;
			}
			set
			{
				this.cGAAJPDAFMG_ = value;
			}
		}

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x06007CB5 RID: 31925 RVA: 0x0014A343 File Offset: 0x00148543
		// (set) Token: 0x06007CB6 RID: 31926 RVA: 0x0014A34B File Offset: 0x0014854B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x06007CB7 RID: 31927 RVA: 0x0014A354 File Offset: 0x00148554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MONFGAKJBGN);
		}

		// Token: 0x06007CB8 RID: 31928 RVA: 0x0014A364 File Offset: 0x00148564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MONFGAKJBGN other)
		{
			return other != null && (other == this || (this.DFEBKIGAJGJ == other.DFEBKIGAJGJ && this.CGAAJPDAFMG == other.CGAAJPDAFMG && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007CB9 RID: 31929 RVA: 0x0014A3C0 File Offset: 0x001485C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DFEBKIGAJGJ != 0U)
			{
				num ^= this.DFEBKIGAJGJ.GetHashCode();
			}
			if (this.CGAAJPDAFMG != 0U)
			{
				num ^= this.CGAAJPDAFMG.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007CBA RID: 31930 RVA: 0x0014A431 File Offset: 0x00148631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007CBB RID: 31931 RVA: 0x0014A439 File Offset: 0x00148639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007CBC RID: 31932 RVA: 0x0014A444 File Offset: 0x00148644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Level);
			}
			if (this.DFEBKIGAJGJ != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.DFEBKIGAJGJ);
			}
			if (this.CGAAJPDAFMG != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.CGAAJPDAFMG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007CBD RID: 31933 RVA: 0x0014A4BC File Offset: 0x001486BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DFEBKIGAJGJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DFEBKIGAJGJ);
			}
			if (this.CGAAJPDAFMG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CGAAJPDAFMG);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007CBE RID: 31934 RVA: 0x0014A52C File Offset: 0x0014872C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MONFGAKJBGN other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DFEBKIGAJGJ != 0U)
			{
				this.DFEBKIGAJGJ = other.DFEBKIGAJGJ;
			}
			if (other.CGAAJPDAFMG != 0U)
			{
				this.CGAAJPDAFMG = other.CGAAJPDAFMG;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007CBF RID: 31935 RVA: 0x0014A590 File Offset: 0x00148790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007CC0 RID: 31936 RVA: 0x0014A59C File Offset: 0x0014879C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 56U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CGAAJPDAFMG = input.ReadUInt32();
						}
					}
					else
					{
						this.DFEBKIGAJGJ = input.ReadUInt32();
					}
				}
				else
				{
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002FEE RID: 12270
		private static readonly MessageParser<MONFGAKJBGN> _parser = new MessageParser<MONFGAKJBGN>(() => new MONFGAKJBGN());

		// Token: 0x04002FEF RID: 12271
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FF0 RID: 12272
		public const int DFEBKIGAJGJFieldNumber = 7;

		// Token: 0x04002FF1 RID: 12273
		private uint dFEBKIGAJGJ_;

		// Token: 0x04002FF2 RID: 12274
		public const int CGAAJPDAFMGFieldNumber = 10;

		// Token: 0x04002FF3 RID: 12275
		private uint cGAAJPDAFMG_;

		// Token: 0x04002FF4 RID: 12276
		public const int LevelFieldNumber = 2;

		// Token: 0x04002FF5 RID: 12277
		private uint level_;
	}
}
