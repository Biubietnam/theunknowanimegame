using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001383 RID: 4995
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochureSelectMessageCsReq : IMessage<TravelBrochureSelectMessageCsReq>, IMessage, IEquatable<TravelBrochureSelectMessageCsReq>, IDeepCloneable<TravelBrochureSelectMessageCsReq>, IBufferMessage
	{
		// Token: 0x17003E93 RID: 16019
		// (get) Token: 0x0600DED4 RID: 57044 RVA: 0x00250FE9 File Offset: 0x0024F1E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochureSelectMessageCsReq> Parser
		{
			get
			{
				return TravelBrochureSelectMessageCsReq._parser;
			}
		}

		// Token: 0x17003E94 RID: 16020
		// (get) Token: 0x0600DED5 RID: 57045 RVA: 0x00250FF0 File Offset: 0x0024F1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochureSelectMessageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E95 RID: 16021
		// (get) Token: 0x0600DED6 RID: 57046 RVA: 0x00251002 File Offset: 0x0024F202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochureSelectMessageCsReq.Descriptor;
			}
		}

		// Token: 0x0600DED7 RID: 57047 RVA: 0x00251009 File Offset: 0x0024F209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSelectMessageCsReq()
		{
		}

		// Token: 0x0600DED8 RID: 57048 RVA: 0x00251011 File Offset: 0x0024F211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSelectMessageCsReq(TravelBrochureSelectMessageCsReq other) : this()
		{
			this.bBKJHABIOMI_ = other.bBKJHABIOMI_;
			this.nMAKNJMFFJN_ = other.nMAKNJMFFJN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DED9 RID: 57049 RVA: 0x00251042 File Offset: 0x0024F242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSelectMessageCsReq Clone()
		{
			return new TravelBrochureSelectMessageCsReq(this);
		}

		// Token: 0x17003E96 RID: 16022
		// (get) Token: 0x0600DEDA RID: 57050 RVA: 0x0025104A File Offset: 0x0024F24A
		// (set) Token: 0x0600DEDB RID: 57051 RVA: 0x00251052 File Offset: 0x0024F252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BBKJHABIOMI
		{
			get
			{
				return this.bBKJHABIOMI_;
			}
			set
			{
				this.bBKJHABIOMI_ = value;
			}
		}

		// Token: 0x17003E97 RID: 16023
		// (get) Token: 0x0600DEDC RID: 57052 RVA: 0x0025105B File Offset: 0x0024F25B
		// (set) Token: 0x0600DEDD RID: 57053 RVA: 0x00251063 File Offset: 0x0024F263
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

		// Token: 0x0600DEDE RID: 57054 RVA: 0x0025106C File Offset: 0x0024F26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochureSelectMessageCsReq);
		}

		// Token: 0x0600DEDF RID: 57055 RVA: 0x0025107A File Offset: 0x0024F27A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochureSelectMessageCsReq other)
		{
			return other != null && (other == this || (this.BBKJHABIOMI == other.BBKJHABIOMI && this.NMAKNJMFFJN == other.NMAKNJMFFJN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DEE0 RID: 57056 RVA: 0x002510B8 File Offset: 0x0024F2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BBKJHABIOMI != 0U)
			{
				num ^= this.BBKJHABIOMI.GetHashCode();
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

		// Token: 0x0600DEE1 RID: 57057 RVA: 0x00251110 File Offset: 0x0024F310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DEE2 RID: 57058 RVA: 0x00251118 File Offset: 0x0024F318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DEE3 RID: 57059 RVA: 0x00251124 File Offset: 0x0024F324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BBKJHABIOMI != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.BBKJHABIOMI);
			}
			if (this.NMAKNJMFFJN != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.NMAKNJMFFJN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DEE4 RID: 57060 RVA: 0x00251180 File Offset: 0x0024F380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BBKJHABIOMI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BBKJHABIOMI);
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

		// Token: 0x0600DEE5 RID: 57061 RVA: 0x002511D8 File Offset: 0x0024F3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochureSelectMessageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BBKJHABIOMI != 0U)
			{
				this.BBKJHABIOMI = other.BBKJHABIOMI;
			}
			if (other.NMAKNJMFFJN != 0U)
			{
				this.NMAKNJMFFJN = other.NMAKNJMFFJN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DEE6 RID: 57062 RVA: 0x00251228 File Offset: 0x0024F428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DEE7 RID: 57063 RVA: 0x00251234 File Offset: 0x0024F434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NMAKNJMFFJN = input.ReadUInt32();
					}
				}
				else
				{
					this.BBKJHABIOMI = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005892 RID: 22674
		private static readonly MessageParser<TravelBrochureSelectMessageCsReq> _parser = new MessageParser<TravelBrochureSelectMessageCsReq>(() => new TravelBrochureSelectMessageCsReq());

		// Token: 0x04005893 RID: 22675
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005894 RID: 22676
		public const int BBKJHABIOMIFieldNumber = 5;

		// Token: 0x04005895 RID: 22677
		private uint bBKJHABIOMI_;

		// Token: 0x04005896 RID: 22678
		public const int NMAKNJMFFJNFieldNumber = 14;

		// Token: 0x04005897 RID: 22679
		private uint nMAKNJMFFJN_;
	}
}
