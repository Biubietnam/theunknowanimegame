using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200099B RID: 2459
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KFJJAGAICDE : IMessage<KFJJAGAICDE>, IMessage, IEquatable<KFJJAGAICDE>, IDeepCloneable<KFJJAGAICDE>, IBufferMessage
	{
		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x06006DEE RID: 28142 RVA: 0x00125D08 File Offset: 0x00123F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KFJJAGAICDE> Parser
		{
			get
			{
				return KFJJAGAICDE._parser;
			}
		}

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x06006DEF RID: 28143 RVA: 0x00125D0F File Offset: 0x00123F0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KFJJAGAICDEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x06006DF0 RID: 28144 RVA: 0x00125D21 File Offset: 0x00123F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KFJJAGAICDE.Descriptor;
			}
		}

		// Token: 0x06006DF1 RID: 28145 RVA: 0x00125D28 File Offset: 0x00123F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KFJJAGAICDE()
		{
		}

		// Token: 0x06006DF2 RID: 28146 RVA: 0x00125D30 File Offset: 0x00123F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KFJJAGAICDE(KFJJAGAICDE other) : this()
		{
			this.fMKOBADLNKI_ = other.fMKOBADLNKI_;
			this.isWin_ = other.isWin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006DF3 RID: 28147 RVA: 0x00125D61 File Offset: 0x00123F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KFJJAGAICDE Clone()
		{
			return new KFJJAGAICDE(this);
		}

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x06006DF4 RID: 28148 RVA: 0x00125D69 File Offset: 0x00123F69
		// (set) Token: 0x06006DF5 RID: 28149 RVA: 0x00125D71 File Offset: 0x00123F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FMKOBADLNKI
		{
			get
			{
				return this.fMKOBADLNKI_;
			}
			set
			{
				this.fMKOBADLNKI_ = value;
			}
		}

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x06006DF6 RID: 28150 RVA: 0x00125D7A File Offset: 0x00123F7A
		// (set) Token: 0x06006DF7 RID: 28151 RVA: 0x00125D82 File Offset: 0x00123F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsWin
		{
			get
			{
				return this.isWin_;
			}
			set
			{
				this.isWin_ = value;
			}
		}

		// Token: 0x06006DF8 RID: 28152 RVA: 0x00125D8B File Offset: 0x00123F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KFJJAGAICDE);
		}

		// Token: 0x06006DF9 RID: 28153 RVA: 0x00125D99 File Offset: 0x00123F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KFJJAGAICDE other)
		{
			return other != null && (other == this || (this.FMKOBADLNKI == other.FMKOBADLNKI && this.IsWin == other.IsWin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006DFA RID: 28154 RVA: 0x00125DD8 File Offset: 0x00123FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FMKOBADLNKI != 0U)
			{
				num ^= this.FMKOBADLNKI.GetHashCode();
			}
			if (this.IsWin)
			{
				num ^= this.IsWin.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006DFB RID: 28155 RVA: 0x00125E30 File Offset: 0x00124030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006DFC RID: 28156 RVA: 0x00125E38 File Offset: 0x00124038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006DFD RID: 28157 RVA: 0x00125E44 File Offset: 0x00124044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsWin)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsWin);
			}
			if (this.FMKOBADLNKI != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.FMKOBADLNKI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006DFE RID: 28158 RVA: 0x00125E9C File Offset: 0x0012409C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FMKOBADLNKI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FMKOBADLNKI);
			}
			if (this.IsWin)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006DFF RID: 28159 RVA: 0x00125EE8 File Offset: 0x001240E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KFJJAGAICDE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FMKOBADLNKI != 0U)
			{
				this.FMKOBADLNKI = other.FMKOBADLNKI;
			}
			if (other.IsWin)
			{
				this.IsWin = other.IsWin;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006E00 RID: 28160 RVA: 0x00125F38 File Offset: 0x00124138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E01 RID: 28161 RVA: 0x00125F44 File Offset: 0x00124144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FMKOBADLNKI = input.ReadUInt32();
					}
				}
				else
				{
					this.IsWin = input.ReadBool();
				}
			}
		}

		// Token: 0x04002A3B RID: 10811
		private static readonly MessageParser<KFJJAGAICDE> _parser = new MessageParser<KFJJAGAICDE>(() => new KFJJAGAICDE());

		// Token: 0x04002A3C RID: 10812
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A3D RID: 10813
		public const int FMKOBADLNKIFieldNumber = 4;

		// Token: 0x04002A3E RID: 10814
		private uint fMKOBADLNKI_;

		// Token: 0x04002A3F RID: 10815
		public const int IsWinFieldNumber = 1;

		// Token: 0x04002A40 RID: 10816
		private bool isWin_;
	}
}
