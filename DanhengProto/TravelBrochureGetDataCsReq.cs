using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001373 RID: 4979
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochureGetDataCsReq : IMessage<TravelBrochureGetDataCsReq>, IMessage, IEquatable<TravelBrochureGetDataCsReq>, IDeepCloneable<TravelBrochureGetDataCsReq>, IBufferMessage
	{
		// Token: 0x17003E64 RID: 15972
		// (get) Token: 0x0600DE20 RID: 56864 RVA: 0x0024F5AF File Offset: 0x0024D7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochureGetDataCsReq> Parser
		{
			get
			{
				return TravelBrochureGetDataCsReq._parser;
			}
		}

		// Token: 0x17003E65 RID: 15973
		// (get) Token: 0x0600DE21 RID: 56865 RVA: 0x0024F5B6 File Offset: 0x0024D7B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochureGetDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003E66 RID: 15974
		// (get) Token: 0x0600DE22 RID: 56866 RVA: 0x0024F5C8 File Offset: 0x0024D7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochureGetDataCsReq.Descriptor;
			}
		}

		// Token: 0x0600DE23 RID: 56867 RVA: 0x0024F5CF File Offset: 0x0024D7CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureGetDataCsReq()
		{
		}

		// Token: 0x0600DE24 RID: 56868 RVA: 0x0024F5D7 File Offset: 0x0024D7D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureGetDataCsReq(TravelBrochureGetDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE25 RID: 56869 RVA: 0x0024F5F0 File Offset: 0x0024D7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureGetDataCsReq Clone()
		{
			return new TravelBrochureGetDataCsReq(this);
		}

		// Token: 0x0600DE26 RID: 56870 RVA: 0x0024F5F8 File Offset: 0x0024D7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochureGetDataCsReq);
		}

		// Token: 0x0600DE27 RID: 56871 RVA: 0x0024F606 File Offset: 0x0024D806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochureGetDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600DE28 RID: 56872 RVA: 0x0024F624 File Offset: 0x0024D824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DE29 RID: 56873 RVA: 0x0024F64A File Offset: 0x0024D84A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DE2A RID: 56874 RVA: 0x0024F652 File Offset: 0x0024D852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE2B RID: 56875 RVA: 0x0024F65B File Offset: 0x0024D85B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DE2C RID: 56876 RVA: 0x0024F674 File Offset: 0x0024D874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DE2D RID: 56877 RVA: 0x0024F69A File Offset: 0x0024D89A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochureGetDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DE2E RID: 56878 RVA: 0x0024F6B7 File Offset: 0x0024D8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE2F RID: 56879 RVA: 0x0024F6C0 File Offset: 0x0024D8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400585A RID: 22618
		private static readonly MessageParser<TravelBrochureGetDataCsReq> _parser = new MessageParser<TravelBrochureGetDataCsReq>(() => new TravelBrochureGetDataCsReq());

		// Token: 0x0400585B RID: 22619
		private UnknownFieldSet _unknownFields;
	}
}
