using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200138B RID: 5003
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochureSetPageDescStatusCsReq : IMessage<TravelBrochureSetPageDescStatusCsReq>, IMessage, IEquatable<TravelBrochureSetPageDescStatusCsReq>, IDeepCloneable<TravelBrochureSetPageDescStatusCsReq>, IBufferMessage
	{
		// Token: 0x17003EAA RID: 16042
		// (get) Token: 0x0600DF2E RID: 57134 RVA: 0x00251CCB File Offset: 0x0024FECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochureSetPageDescStatusCsReq> Parser
		{
			get
			{
				return TravelBrochureSetPageDescStatusCsReq._parser;
			}
		}

		// Token: 0x17003EAB RID: 16043
		// (get) Token: 0x0600DF2F RID: 57135 RVA: 0x00251CD2 File Offset: 0x0024FED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochureSetPageDescStatusCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003EAC RID: 16044
		// (get) Token: 0x0600DF30 RID: 57136 RVA: 0x00251CE4 File Offset: 0x0024FEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochureSetPageDescStatusCsReq.Descriptor;
			}
		}

		// Token: 0x0600DF31 RID: 57137 RVA: 0x00251CEB File Offset: 0x0024FEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSetPageDescStatusCsReq()
		{
		}

		// Token: 0x0600DF32 RID: 57138 RVA: 0x00251CF3 File Offset: 0x0024FEF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSetPageDescStatusCsReq(TravelBrochureSetPageDescStatusCsReq other) : this()
		{
			this.eKBNIFPCFFH_ = other.eKBNIFPCFFH_;
			this.nMAKNJMFFJN_ = other.nMAKNJMFFJN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF33 RID: 57139 RVA: 0x00251D24 File Offset: 0x0024FF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSetPageDescStatusCsReq Clone()
		{
			return new TravelBrochureSetPageDescStatusCsReq(this);
		}

		// Token: 0x17003EAD RID: 16045
		// (get) Token: 0x0600DF34 RID: 57140 RVA: 0x00251D2C File Offset: 0x0024FF2C
		// (set) Token: 0x0600DF35 RID: 57141 RVA: 0x00251D34 File Offset: 0x0024FF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DNJIJPCJIOD EKBNIFPCFFH
		{
			get
			{
				return this.eKBNIFPCFFH_;
			}
			set
			{
				this.eKBNIFPCFFH_ = value;
			}
		}

		// Token: 0x17003EAE RID: 16046
		// (get) Token: 0x0600DF36 RID: 57142 RVA: 0x00251D3D File Offset: 0x0024FF3D
		// (set) Token: 0x0600DF37 RID: 57143 RVA: 0x00251D45 File Offset: 0x0024FF45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NMAKNJMFFJN
		{
			get
			{
				return this.nMAKNJMFFJN_;
			}
			set
			{
				this.nMAKNJMFFJN_ = value;
			}
		}

		// Token: 0x0600DF38 RID: 57144 RVA: 0x00251D4E File Offset: 0x0024FF4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochureSetPageDescStatusCsReq);
		}

		// Token: 0x0600DF39 RID: 57145 RVA: 0x00251D5C File Offset: 0x0024FF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochureSetPageDescStatusCsReq other)
		{
			return other != null && (other == this || (this.EKBNIFPCFFH == other.EKBNIFPCFFH && this.NMAKNJMFFJN == other.NMAKNJMFFJN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF3A RID: 57146 RVA: 0x00251D9C File Offset: 0x0024FF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EKBNIFPCFFH != DNJIJPCJIOD.PageDescNone)
			{
				num ^= this.EKBNIFPCFFH.GetHashCode();
			}
			if (this.NMAKNJMFFJN != 0U)
			{
				num ^= this.NMAKNJMFFJN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DF3B RID: 57147 RVA: 0x00251DFA File Offset: 0x0024FFFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DF3C RID: 57148 RVA: 0x00251E02 File Offset: 0x00250002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF3D RID: 57149 RVA: 0x00251E0C File Offset: 0x0025000C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NMAKNJMFFJN != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.NMAKNJMFFJN);
			}
			if (this.EKBNIFPCFFH != DNJIJPCJIOD.PageDescNone)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.EKBNIFPCFFH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DF3E RID: 57150 RVA: 0x00251E64 File Offset: 0x00250064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EKBNIFPCFFH != DNJIJPCJIOD.PageDescNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.EKBNIFPCFFH);
			}
			if (this.NMAKNJMFFJN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NMAKNJMFFJN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DF3F RID: 57151 RVA: 0x00251EBC File Offset: 0x002500BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochureSetPageDescStatusCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EKBNIFPCFFH != DNJIJPCJIOD.PageDescNone)
			{
				this.EKBNIFPCFFH = other.EKBNIFPCFFH;
			}
			if (other.NMAKNJMFFJN != 0U)
			{
				this.NMAKNJMFFJN = other.NMAKNJMFFJN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DF40 RID: 57152 RVA: 0x00251F0C File Offset: 0x0025010C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF41 RID: 57153 RVA: 0x00251F18 File Offset: 0x00250118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EKBNIFPCFFH = (DNJIJPCJIOD)input.ReadEnum();
					}
				}
				else
				{
					this.NMAKNJMFFJN = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040058AC RID: 22700
		private static readonly MessageParser<TravelBrochureSetPageDescStatusCsReq> _parser = new MessageParser<TravelBrochureSetPageDescStatusCsReq>(() => new TravelBrochureSetPageDescStatusCsReq());

		// Token: 0x040058AD RID: 22701
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058AE RID: 22702
		public const int EKBNIFPCFFHFieldNumber = 10;

		// Token: 0x040058AF RID: 22703
		private DNJIJPCJIOD eKBNIFPCFFH_;

		// Token: 0x040058B0 RID: 22704
		public const int NMAKNJMFFJNFieldNumber = 1;

		// Token: 0x040058B1 RID: 22705
		private uint nMAKNJMFFJN_;
	}
}
