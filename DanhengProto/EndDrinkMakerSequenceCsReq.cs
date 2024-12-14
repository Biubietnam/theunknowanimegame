using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200041B RID: 1051
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EndDrinkMakerSequenceCsReq : IMessage<EndDrinkMakerSequenceCsReq>, IMessage, IEquatable<EndDrinkMakerSequenceCsReq>, IDeepCloneable<EndDrinkMakerSequenceCsReq>, IBufferMessage
	{
		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06002EAB RID: 11947 RVA: 0x00080E0B File Offset: 0x0007F00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EndDrinkMakerSequenceCsReq> Parser
		{
			get
			{
				return EndDrinkMakerSequenceCsReq._parser;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06002EAC RID: 11948 RVA: 0x00080E12 File Offset: 0x0007F012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EndDrinkMakerSequenceCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06002EAD RID: 11949 RVA: 0x00080E24 File Offset: 0x0007F024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EndDrinkMakerSequenceCsReq.Descriptor;
			}
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x00080E2B File Offset: 0x0007F02B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndDrinkMakerSequenceCsReq()
		{
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x00080E33 File Offset: 0x0007F033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndDrinkMakerSequenceCsReq(EndDrinkMakerSequenceCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x00080E4C File Offset: 0x0007F04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndDrinkMakerSequenceCsReq Clone()
		{
			return new EndDrinkMakerSequenceCsReq(this);
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x00080E54 File Offset: 0x0007F054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EndDrinkMakerSequenceCsReq);
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x00080E62 File Offset: 0x0007F062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EndDrinkMakerSequenceCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x00080E80 File Offset: 0x0007F080
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

		// Token: 0x06002EB4 RID: 11956 RVA: 0x00080EA6 File Offset: 0x0007F0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x00080EAE File Offset: 0x0007F0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x00080EB7 File Offset: 0x0007F0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x00080ED0 File Offset: 0x0007F0D0
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

		// Token: 0x06002EB8 RID: 11960 RVA: 0x00080EF6 File Offset: 0x0007F0F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EndDrinkMakerSequenceCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x00080F13 File Offset: 0x0007F113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x00080F1C File Offset: 0x0007F11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040012B8 RID: 4792
		private static readonly MessageParser<EndDrinkMakerSequenceCsReq> _parser = new MessageParser<EndDrinkMakerSequenceCsReq>(() => new EndDrinkMakerSequenceCsReq());

		// Token: 0x040012B9 RID: 4793
		private UnknownFieldSet _unknownFields;
	}
}
