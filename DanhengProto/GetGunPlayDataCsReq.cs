using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006E1 RID: 1761
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetGunPlayDataCsReq : IMessage<GetGunPlayDataCsReq>, IMessage, IEquatable<GetGunPlayDataCsReq>, IDeepCloneable<GetGunPlayDataCsReq>, IBufferMessage
	{
		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06004ECB RID: 20171 RVA: 0x000D51EE File Offset: 0x000D33EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetGunPlayDataCsReq> Parser
		{
			get
			{
				return GetGunPlayDataCsReq._parser;
			}
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x06004ECC RID: 20172 RVA: 0x000D51F5 File Offset: 0x000D33F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetGunPlayDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x06004ECD RID: 20173 RVA: 0x000D5207 File Offset: 0x000D3407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGunPlayDataCsReq.Descriptor;
			}
		}

		// Token: 0x06004ECE RID: 20174 RVA: 0x000D520E File Offset: 0x000D340E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGunPlayDataCsReq()
		{
		}

		// Token: 0x06004ECF RID: 20175 RVA: 0x000D5216 File Offset: 0x000D3416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGunPlayDataCsReq(GetGunPlayDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004ED0 RID: 20176 RVA: 0x000D522F File Offset: 0x000D342F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetGunPlayDataCsReq Clone()
		{
			return new GetGunPlayDataCsReq(this);
		}

		// Token: 0x06004ED1 RID: 20177 RVA: 0x000D5237 File Offset: 0x000D3437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGunPlayDataCsReq);
		}

		// Token: 0x06004ED2 RID: 20178 RVA: 0x000D5245 File Offset: 0x000D3445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetGunPlayDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004ED3 RID: 20179 RVA: 0x000D5264 File Offset: 0x000D3464
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

		// Token: 0x06004ED4 RID: 20180 RVA: 0x000D528A File Offset: 0x000D348A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004ED5 RID: 20181 RVA: 0x000D5292 File Offset: 0x000D3492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004ED6 RID: 20182 RVA: 0x000D529B File Offset: 0x000D349B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004ED7 RID: 20183 RVA: 0x000D52B4 File Offset: 0x000D34B4
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

		// Token: 0x06004ED8 RID: 20184 RVA: 0x000D52DA File Offset: 0x000D34DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetGunPlayDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004ED9 RID: 20185 RVA: 0x000D52F7 File Offset: 0x000D34F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004EDA RID: 20186 RVA: 0x000D5300 File Offset: 0x000D3500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F1B RID: 7963
		private static readonly MessageParser<GetGunPlayDataCsReq> _parser = new MessageParser<GetGunPlayDataCsReq>(() => new GetGunPlayDataCsReq());

		// Token: 0x04001F1C RID: 7964
		private UnknownFieldSet _unknownFields;
	}
}
