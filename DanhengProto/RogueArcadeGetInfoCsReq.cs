using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DF7 RID: 3575
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueArcadeGetInfoCsReq : IMessage<RogueArcadeGetInfoCsReq>, IMessage, IEquatable<RogueArcadeGetInfoCsReq>, IDeepCloneable<RogueArcadeGetInfoCsReq>, IBufferMessage
	{
		// Token: 0x17002D2A RID: 11562
		// (get) Token: 0x06009FE3 RID: 40931 RVA: 0x001AD57B File Offset: 0x001AB77B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueArcadeGetInfoCsReq> Parser
		{
			get
			{
				return RogueArcadeGetInfoCsReq._parser;
			}
		}

		// Token: 0x17002D2B RID: 11563
		// (get) Token: 0x06009FE4 RID: 40932 RVA: 0x001AD582 File Offset: 0x001AB782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueArcadeGetInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D2C RID: 11564
		// (get) Token: 0x06009FE5 RID: 40933 RVA: 0x001AD594 File Offset: 0x001AB794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArcadeGetInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06009FE6 RID: 40934 RVA: 0x001AD59B File Offset: 0x001AB79B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeGetInfoCsReq()
		{
		}

		// Token: 0x06009FE7 RID: 40935 RVA: 0x001AD5A3 File Offset: 0x001AB7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeGetInfoCsReq(RogueArcadeGetInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FE8 RID: 40936 RVA: 0x001AD5BC File Offset: 0x001AB7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeGetInfoCsReq Clone()
		{
			return new RogueArcadeGetInfoCsReq(this);
		}

		// Token: 0x06009FE9 RID: 40937 RVA: 0x001AD5C4 File Offset: 0x001AB7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArcadeGetInfoCsReq);
		}

		// Token: 0x06009FEA RID: 40938 RVA: 0x001AD5D2 File Offset: 0x001AB7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArcadeGetInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009FEB RID: 40939 RVA: 0x001AD5F0 File Offset: 0x001AB7F0
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

		// Token: 0x06009FEC RID: 40940 RVA: 0x001AD616 File Offset: 0x001AB816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009FED RID: 40941 RVA: 0x001AD61E File Offset: 0x001AB81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FEE RID: 40942 RVA: 0x001AD627 File Offset: 0x001AB827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009FEF RID: 40943 RVA: 0x001AD640 File Offset: 0x001AB840
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

		// Token: 0x06009FF0 RID: 40944 RVA: 0x001AD666 File Offset: 0x001AB866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueArcadeGetInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009FF1 RID: 40945 RVA: 0x001AD683 File Offset: 0x001AB883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FF2 RID: 40946 RVA: 0x001AD68C File Offset: 0x001AB88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004194 RID: 16788
		private static readonly MessageParser<RogueArcadeGetInfoCsReq> _parser = new MessageParser<RogueArcadeGetInfoCsReq>(() => new RogueArcadeGetInfoCsReq());

		// Token: 0x04004195 RID: 16789
		private UnknownFieldSet _unknownFields;
	}
}
