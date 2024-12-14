using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200065B RID: 1627
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetChessRogueNousStoryInfoCsReq : IMessage<GetChessRogueNousStoryInfoCsReq>, IMessage, IEquatable<GetChessRogueNousStoryInfoCsReq>, IDeepCloneable<GetChessRogueNousStoryInfoCsReq>, IBufferMessage
	{
		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x060048F4 RID: 18676 RVA: 0x000C739B File Offset: 0x000C559B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetChessRogueNousStoryInfoCsReq> Parser
		{
			get
			{
				return GetChessRogueNousStoryInfoCsReq._parser;
			}
		}

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x060048F5 RID: 18677 RVA: 0x000C73A2 File Offset: 0x000C55A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetChessRogueNousStoryInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x060048F6 RID: 18678 RVA: 0x000C73B4 File Offset: 0x000C55B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetChessRogueNousStoryInfoCsReq.Descriptor;
			}
		}

		// Token: 0x060048F7 RID: 18679 RVA: 0x000C73BB File Offset: 0x000C55BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueNousStoryInfoCsReq()
		{
		}

		// Token: 0x060048F8 RID: 18680 RVA: 0x000C73C3 File Offset: 0x000C55C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueNousStoryInfoCsReq(GetChessRogueNousStoryInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060048F9 RID: 18681 RVA: 0x000C73DC File Offset: 0x000C55DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetChessRogueNousStoryInfoCsReq Clone()
		{
			return new GetChessRogueNousStoryInfoCsReq(this);
		}

		// Token: 0x060048FA RID: 18682 RVA: 0x000C73E4 File Offset: 0x000C55E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetChessRogueNousStoryInfoCsReq);
		}

		// Token: 0x060048FB RID: 18683 RVA: 0x000C73F2 File Offset: 0x000C55F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetChessRogueNousStoryInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x000C7410 File Offset: 0x000C5610
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

		// Token: 0x060048FD RID: 18685 RVA: 0x000C7436 File Offset: 0x000C5636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x000C743E File Offset: 0x000C563E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x000C7447 File Offset: 0x000C5647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x000C7460 File Offset: 0x000C5660
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

		// Token: 0x06004901 RID: 18689 RVA: 0x000C7486 File Offset: 0x000C5686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetChessRogueNousStoryInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x000C74A3 File Offset: 0x000C56A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x000C74AC File Offset: 0x000C56AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D18 RID: 7448
		private static readonly MessageParser<GetChessRogueNousStoryInfoCsReq> _parser = new MessageParser<GetChessRogueNousStoryInfoCsReq>(() => new GetChessRogueNousStoryInfoCsReq());

		// Token: 0x04001D19 RID: 7449
		private UnknownFieldSet _unknownFields;
	}
}
