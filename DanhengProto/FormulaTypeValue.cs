using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005B9 RID: 1465
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FormulaTypeValue : IMessage<FormulaTypeValue>, IMessage, IEquatable<FormulaTypeValue>, IDeepCloneable<FormulaTypeValue>, IBufferMessage
	{
		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06004180 RID: 16768 RVA: 0x000B279C File Offset: 0x000B099C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FormulaTypeValue> Parser
		{
			get
			{
				return FormulaTypeValue._parser;
			}
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x06004181 RID: 16769 RVA: 0x000B27A3 File Offset: 0x000B09A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FormulaTypeValueReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06004182 RID: 16770 RVA: 0x000B27B5 File Offset: 0x000B09B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormulaTypeValue.Descriptor;
			}
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x000B27BC File Offset: 0x000B09BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormulaTypeValue()
		{
		}

		// Token: 0x06004184 RID: 16772 RVA: 0x000B27CF File Offset: 0x000B09CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormulaTypeValue(FormulaTypeValue other) : this()
		{
			this.formulaTypeMap_ = other.formulaTypeMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x000B27F9 File Offset: 0x000B09F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormulaTypeValue Clone()
		{
			return new FormulaTypeValue(this);
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x06004186 RID: 16774 RVA: 0x000B2801 File Offset: 0x000B0A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, int> FormulaTypeMap
		{
			get
			{
				return this.formulaTypeMap_;
			}
		}

		// Token: 0x06004187 RID: 16775 RVA: 0x000B2809 File Offset: 0x000B0A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormulaTypeValue);
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x000B2817 File Offset: 0x000B0A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormulaTypeValue other)
		{
			return other != null && (other == this || (this.FormulaTypeMap.Equals(other.FormulaTypeMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x000B284C File Offset: 0x000B0A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.FormulaTypeMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600418A RID: 16778 RVA: 0x000B2880 File Offset: 0x000B0A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600418B RID: 16779 RVA: 0x000B2888 File Offset: 0x000B0A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x000B2891 File Offset: 0x000B0A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.formulaTypeMap_.WriteTo(ref output, FormulaTypeValue._map_formulaTypeMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x000B28B8 File Offset: 0x000B0AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.formulaTypeMap_.CalculateSize(FormulaTypeValue._map_formulaTypeMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x000B28F1 File Offset: 0x000B0AF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormulaTypeValue other)
		{
			if (other == null)
			{
				return;
			}
			this.formulaTypeMap_.MergeFrom(other.formulaTypeMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x000B291F File Offset: 0x000B0B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x000B2928 File Offset: 0x000B0B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.formulaTypeMap_.AddEntriesFrom(ref input, FormulaTypeValue._map_formulaTypeMap_codec);
				}
			}
		}

		// Token: 0x04001A01 RID: 6657
		private static readonly MessageParser<FormulaTypeValue> _parser = new MessageParser<FormulaTypeValue>(() => new FormulaTypeValue());

		// Token: 0x04001A02 RID: 6658
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A03 RID: 6659
		public const int FormulaTypeMapFieldNumber = 8;

		// Token: 0x04001A04 RID: 6660
		private static readonly MapField<uint, int>.Codec _map_formulaTypeMap_codec = new MapField<uint, int>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForInt32(16U, 0), 66U);

		// Token: 0x04001A05 RID: 6661
		private readonly MapField<uint, int> formulaTypeMap_ = new MapField<uint, int>();
	}
}
