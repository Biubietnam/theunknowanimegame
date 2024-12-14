using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001387 RID: 4999
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochureSetCustomValueCsReq : IMessage<TravelBrochureSetCustomValueCsReq>, IMessage, IEquatable<TravelBrochureSetCustomValueCsReq>, IDeepCloneable<TravelBrochureSetCustomValueCsReq>, IBufferMessage
	{
		// Token: 0x17003EA0 RID: 16032
		// (get) Token: 0x0600DF04 RID: 57092 RVA: 0x002517BC File Offset: 0x0024F9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochureSetCustomValueCsReq> Parser
		{
			get
			{
				return TravelBrochureSetCustomValueCsReq._parser;
			}
		}

		// Token: 0x17003EA1 RID: 16033
		// (get) Token: 0x0600DF05 RID: 57093 RVA: 0x002517C3 File Offset: 0x0024F9C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochureSetCustomValueCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003EA2 RID: 16034
		// (get) Token: 0x0600DF06 RID: 57094 RVA: 0x002517D5 File Offset: 0x0024F9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochureSetCustomValueCsReq.Descriptor;
			}
		}

		// Token: 0x0600DF07 RID: 57095 RVA: 0x002517DC File Offset: 0x0024F9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSetCustomValueCsReq()
		{
		}

		// Token: 0x0600DF08 RID: 57096 RVA: 0x002517E4 File Offset: 0x0024F9E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSetCustomValueCsReq(TravelBrochureSetCustomValueCsReq other) : this()
		{
			this.value_ = other.value_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF09 RID: 57097 RVA: 0x00251809 File Offset: 0x0024FA09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSetCustomValueCsReq Clone()
		{
			return new TravelBrochureSetCustomValueCsReq(this);
		}

		// Token: 0x17003EA3 RID: 16035
		// (get) Token: 0x0600DF0A RID: 57098 RVA: 0x00251811 File Offset: 0x0024FA11
		// (set) Token: 0x0600DF0B RID: 57099 RVA: 0x00251819 File Offset: 0x0024FA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x0600DF0C RID: 57100 RVA: 0x00251822 File Offset: 0x0024FA22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochureSetCustomValueCsReq);
		}

		// Token: 0x0600DF0D RID: 57101 RVA: 0x00251830 File Offset: 0x0024FA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochureSetCustomValueCsReq other)
		{
			return other != null && (other == this || (this.Value == other.Value && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF0E RID: 57102 RVA: 0x00251860 File Offset: 0x0024FA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Value != 0U)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DF0F RID: 57103 RVA: 0x0025189F File Offset: 0x0024FA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DF10 RID: 57104 RVA: 0x002518A7 File Offset: 0x0024FAA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF11 RID: 57105 RVA: 0x002518B0 File Offset: 0x0024FAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Value != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Value);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DF12 RID: 57106 RVA: 0x002518E4 File Offset: 0x0024FAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Value != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Value);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DF13 RID: 57107 RVA: 0x00251922 File Offset: 0x0024FB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochureSetCustomValueCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Value != 0U)
			{
				this.Value = other.Value;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DF14 RID: 57108 RVA: 0x00251953 File Offset: 0x0024FB53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF15 RID: 57109 RVA: 0x0025195C File Offset: 0x0024FB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Value = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040058A2 RID: 22690
		private static readonly MessageParser<TravelBrochureSetCustomValueCsReq> _parser = new MessageParser<TravelBrochureSetCustomValueCsReq>(() => new TravelBrochureSetCustomValueCsReq());

		// Token: 0x040058A3 RID: 22691
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058A4 RID: 22692
		public const int ValueFieldNumber = 14;

		// Token: 0x040058A5 RID: 22693
		private uint value_;
	}
}
