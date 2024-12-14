using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000259 RID: 601
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueNousGetRogueTalentInfoCsReq : IMessage<ChessRogueNousGetRogueTalentInfoCsReq>, IMessage, IEquatable<ChessRogueNousGetRogueTalentInfoCsReq>, IDeepCloneable<ChessRogueNousGetRogueTalentInfoCsReq>, IBufferMessage
	{
		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x0004DDE3 File Offset: 0x0004BFE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueNousGetRogueTalentInfoCsReq> Parser
		{
			get
			{
				return ChessRogueNousGetRogueTalentInfoCsReq._parser;
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x0004DDEA File Offset: 0x0004BFEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueNousGetRogueTalentInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001AED RID: 6893 RVA: 0x0004DDFC File Offset: 0x0004BFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueNousGetRogueTalentInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x0004DE03 File Offset: 0x0004C003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousGetRogueTalentInfoCsReq()
		{
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x0004DE0B File Offset: 0x0004C00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousGetRogueTalentInfoCsReq(ChessRogueNousGetRogueTalentInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x0004DE24 File Offset: 0x0004C024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousGetRogueTalentInfoCsReq Clone()
		{
			return new ChessRogueNousGetRogueTalentInfoCsReq(this);
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x0004DE2C File Offset: 0x0004C02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueNousGetRogueTalentInfoCsReq);
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x0004DE3A File Offset: 0x0004C03A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueNousGetRogueTalentInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x0004DE58 File Offset: 0x0004C058
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

		// Token: 0x06001AF4 RID: 6900 RVA: 0x0004DE7E File Offset: 0x0004C07E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x0004DE86 File Offset: 0x0004C086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x0004DE8F File Offset: 0x0004C08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0004DEA8 File Offset: 0x0004C0A8
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

		// Token: 0x06001AF8 RID: 6904 RVA: 0x0004DECE File Offset: 0x0004C0CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueNousGetRogueTalentInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0004DEEB File Offset: 0x0004C0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x0004DEF4 File Offset: 0x0004C0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000B62 RID: 2914
		private static readonly MessageParser<ChessRogueNousGetRogueTalentInfoCsReq> _parser = new MessageParser<ChessRogueNousGetRogueTalentInfoCsReq>(() => new ChessRogueNousGetRogueTalentInfoCsReq());

		// Token: 0x04000B63 RID: 2915
		private UnknownFieldSet _unknownFields;
	}
}
