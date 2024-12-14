using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200026B RID: 619
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueQueryAeonDimensionsCsReq : IMessage<ChessRogueQueryAeonDimensionsCsReq>, IMessage, IEquatable<ChessRogueQueryAeonDimensionsCsReq>, IDeepCloneable<ChessRogueQueryAeonDimensionsCsReq>, IBufferMessage
	{
		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x0004F7BB File Offset: 0x0004D9BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueQueryAeonDimensionsCsReq> Parser
		{
			get
			{
				return ChessRogueQueryAeonDimensionsCsReq._parser;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x0004F7C2 File Offset: 0x0004D9C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueQueryAeonDimensionsCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001BA1 RID: 7073 RVA: 0x0004F7D4 File Offset: 0x0004D9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueQueryAeonDimensionsCsReq.Descriptor;
			}
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0004F7DB File Offset: 0x0004D9DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryAeonDimensionsCsReq()
		{
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0004F7E3 File Offset: 0x0004D9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryAeonDimensionsCsReq(ChessRogueQueryAeonDimensionsCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0004F7FC File Offset: 0x0004D9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryAeonDimensionsCsReq Clone()
		{
			return new ChessRogueQueryAeonDimensionsCsReq(this);
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x0004F804 File Offset: 0x0004DA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueQueryAeonDimensionsCsReq);
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0004F812 File Offset: 0x0004DA12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueQueryAeonDimensionsCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0004F830 File Offset: 0x0004DA30
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

		// Token: 0x06001BA8 RID: 7080 RVA: 0x0004F856 File Offset: 0x0004DA56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0004F85E File Offset: 0x0004DA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x0004F867 File Offset: 0x0004DA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0004F880 File Offset: 0x0004DA80
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

		// Token: 0x06001BAC RID: 7084 RVA: 0x0004F8A6 File Offset: 0x0004DAA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueQueryAeonDimensionsCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0004F8C3 File Offset: 0x0004DAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x0004F8CC File Offset: 0x0004DACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000B9E RID: 2974
		private static readonly MessageParser<ChessRogueQueryAeonDimensionsCsReq> _parser = new MessageParser<ChessRogueQueryAeonDimensionsCsReq>(() => new ChessRogueQueryAeonDimensionsCsReq());

		// Token: 0x04000B9F RID: 2975
		private UnknownFieldSet _unknownFields;
	}
}
