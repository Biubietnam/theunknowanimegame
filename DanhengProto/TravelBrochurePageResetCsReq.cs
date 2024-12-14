using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001379 RID: 4985
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochurePageResetCsReq : IMessage<TravelBrochurePageResetCsReq>, IMessage, IEquatable<TravelBrochurePageResetCsReq>, IDeepCloneable<TravelBrochurePageResetCsReq>, IBufferMessage
	{
		// Token: 0x17003E76 RID: 15990
		// (get) Token: 0x0600DE63 RID: 56931 RVA: 0x0024FFC4 File Offset: 0x0024E1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochurePageResetCsReq> Parser
		{
			get
			{
				return TravelBrochurePageResetCsReq._parser;
			}
		}

		// Token: 0x17003E77 RID: 15991
		// (get) Token: 0x0600DE64 RID: 56932 RVA: 0x0024FFCB File Offset: 0x0024E1CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochurePageResetCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E78 RID: 15992
		// (get) Token: 0x0600DE65 RID: 56933 RVA: 0x0024FFDD File Offset: 0x0024E1DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochurePageResetCsReq.Descriptor;
			}
		}

		// Token: 0x0600DE66 RID: 56934 RVA: 0x0024FFE4 File Offset: 0x0024E1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochurePageResetCsReq()
		{
		}

		// Token: 0x0600DE67 RID: 56935 RVA: 0x0024FFEC File Offset: 0x0024E1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochurePageResetCsReq(TravelBrochurePageResetCsReq other) : this()
		{
			this.nMAKNJMFFJN_ = other.nMAKNJMFFJN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE68 RID: 56936 RVA: 0x00250011 File Offset: 0x0024E211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochurePageResetCsReq Clone()
		{
			return new TravelBrochurePageResetCsReq(this);
		}

		// Token: 0x17003E79 RID: 15993
		// (get) Token: 0x0600DE69 RID: 56937 RVA: 0x00250019 File Offset: 0x0024E219
		// (set) Token: 0x0600DE6A RID: 56938 RVA: 0x00250021 File Offset: 0x0024E221
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

		// Token: 0x0600DE6B RID: 56939 RVA: 0x0025002A File Offset: 0x0024E22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochurePageResetCsReq);
		}

		// Token: 0x0600DE6C RID: 56940 RVA: 0x00250038 File Offset: 0x0024E238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochurePageResetCsReq other)
		{
			return other != null && (other == this || (this.NMAKNJMFFJN == other.NMAKNJMFFJN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE6D RID: 56941 RVA: 0x00250068 File Offset: 0x0024E268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600DE6E RID: 56942 RVA: 0x002500A7 File Offset: 0x0024E2A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DE6F RID: 56943 RVA: 0x002500AF File Offset: 0x0024E2AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE70 RID: 56944 RVA: 0x002500B8 File Offset: 0x0024E2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NMAKNJMFFJN != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.NMAKNJMFFJN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE71 RID: 56945 RVA: 0x002500EC File Offset: 0x0024E2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600DE72 RID: 56946 RVA: 0x0025012A File Offset: 0x0024E32A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochurePageResetCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NMAKNJMFFJN != 0U)
			{
				this.NMAKNJMFFJN = other.NMAKNJMFFJN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DE73 RID: 56947 RVA: 0x0025015B File Offset: 0x0024E35B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE74 RID: 56948 RVA: 0x00250164 File Offset: 0x0024E364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.NMAKNJMFFJN = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005871 RID: 22641
		private static readonly MessageParser<TravelBrochurePageResetCsReq> _parser = new MessageParser<TravelBrochurePageResetCsReq>(() => new TravelBrochurePageResetCsReq());

		// Token: 0x04005872 RID: 22642
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005873 RID: 22643
		public const int NMAKNJMFFJNFieldNumber = 9;

		// Token: 0x04005874 RID: 22644
		private uint nMAKNJMFFJN_;
	}
}
