using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AF9 RID: 2809
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MNCJPNFJLBC : IMessage<MNCJPNFJLBC>, IMessage, IEquatable<MNCJPNFJLBC>, IDeepCloneable<MNCJPNFJLBC>, IBufferMessage
	{
		// Token: 0x170022E6 RID: 8934
		// (get) Token: 0x06007C47 RID: 31815 RVA: 0x0014914C File Offset: 0x0014734C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MNCJPNFJLBC> Parser
		{
			get
			{
				return MNCJPNFJLBC._parser;
			}
		}

		// Token: 0x170022E7 RID: 8935
		// (get) Token: 0x06007C48 RID: 31816 RVA: 0x00149153 File Offset: 0x00147353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MNCJPNFJLBCReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170022E8 RID: 8936
		// (get) Token: 0x06007C49 RID: 31817 RVA: 0x00149165 File Offset: 0x00147365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MNCJPNFJLBC.Descriptor;
			}
		}

		// Token: 0x06007C4A RID: 31818 RVA: 0x0014916C File Offset: 0x0014736C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MNCJPNFJLBC()
		{
		}

		// Token: 0x06007C4B RID: 31819 RVA: 0x00149174 File Offset: 0x00147374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MNCJPNFJLBC(MNCJPNFJLBC other) : this()
		{
			this.formulaId_ = other.formulaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C4C RID: 31820 RVA: 0x00149199 File Offset: 0x00147399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MNCJPNFJLBC Clone()
		{
			return new MNCJPNFJLBC(this);
		}

		// Token: 0x170022E9 RID: 8937
		// (get) Token: 0x06007C4D RID: 31821 RVA: 0x001491A1 File Offset: 0x001473A1
		// (set) Token: 0x06007C4E RID: 31822 RVA: 0x001491A9 File Offset: 0x001473A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FormulaId
		{
			get
			{
				return this.formulaId_;
			}
			set
			{
				this.formulaId_ = value;
			}
		}

		// Token: 0x06007C4F RID: 31823 RVA: 0x001491B2 File Offset: 0x001473B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MNCJPNFJLBC);
		}

		// Token: 0x06007C50 RID: 31824 RVA: 0x001491C0 File Offset: 0x001473C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MNCJPNFJLBC other)
		{
			return other != null && (other == this || (this.FormulaId == other.FormulaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C51 RID: 31825 RVA: 0x001491F0 File Offset: 0x001473F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FormulaId != 0U)
			{
				num ^= this.FormulaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007C52 RID: 31826 RVA: 0x0014922F File Offset: 0x0014742F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007C53 RID: 31827 RVA: 0x00149237 File Offset: 0x00147437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C54 RID: 31828 RVA: 0x00149240 File Offset: 0x00147440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FormulaId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.FormulaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C55 RID: 31829 RVA: 0x00149274 File Offset: 0x00147474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FormulaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FormulaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007C56 RID: 31830 RVA: 0x001492B2 File Offset: 0x001474B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MNCJPNFJLBC other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FormulaId != 0U)
			{
				this.FormulaId = other.FormulaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007C57 RID: 31831 RVA: 0x001492E3 File Offset: 0x001474E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C58 RID: 31832 RVA: 0x001492EC File Offset: 0x001474EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FormulaId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002FCA RID: 12234
		private static readonly MessageParser<MNCJPNFJLBC> _parser = new MessageParser<MNCJPNFJLBC>(() => new MNCJPNFJLBC());

		// Token: 0x04002FCB RID: 12235
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FCC RID: 12236
		public const int FormulaIdFieldNumber = 7;

		// Token: 0x04002FCD RID: 12237
		private uint formulaId_;
	}
}
