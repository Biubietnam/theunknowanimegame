using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007C5 RID: 1989
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueInitialScoreCsReq : IMessage<GetRogueInitialScoreCsReq>, IMessage, IEquatable<GetRogueInitialScoreCsReq>, IDeepCloneable<GetRogueInitialScoreCsReq>, IBufferMessage
	{
		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x060058B7 RID: 22711 RVA: 0x000ECFA3 File Offset: 0x000EB1A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueInitialScoreCsReq> Parser
		{
			get
			{
				return GetRogueInitialScoreCsReq._parser;
			}
		}

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x060058B8 RID: 22712 RVA: 0x000ECFAA File Offset: 0x000EB1AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueInitialScoreCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x060058B9 RID: 22713 RVA: 0x000ECFBC File Offset: 0x000EB1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueInitialScoreCsReq.Descriptor;
			}
		}

		// Token: 0x060058BA RID: 22714 RVA: 0x000ECFC3 File Offset: 0x000EB1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueInitialScoreCsReq()
		{
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x000ECFCB File Offset: 0x000EB1CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueInitialScoreCsReq(GetRogueInitialScoreCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x000ECFE4 File Offset: 0x000EB1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueInitialScoreCsReq Clone()
		{
			return new GetRogueInitialScoreCsReq(this);
		}

		// Token: 0x060058BD RID: 22717 RVA: 0x000ECFEC File Offset: 0x000EB1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueInitialScoreCsReq);
		}

		// Token: 0x060058BE RID: 22718 RVA: 0x000ECFFA File Offset: 0x000EB1FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueInitialScoreCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060058BF RID: 22719 RVA: 0x000ED018 File Offset: 0x000EB218
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

		// Token: 0x060058C0 RID: 22720 RVA: 0x000ED03E File Offset: 0x000EB23E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060058C1 RID: 22721 RVA: 0x000ED046 File Offset: 0x000EB246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060058C2 RID: 22722 RVA: 0x000ED04F File Offset: 0x000EB24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060058C3 RID: 22723 RVA: 0x000ED068 File Offset: 0x000EB268
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

		// Token: 0x060058C4 RID: 22724 RVA: 0x000ED08E File Offset: 0x000EB28E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueInitialScoreCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x000ED0AB File Offset: 0x000EB2AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x000ED0B4 File Offset: 0x000EB2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400228B RID: 8843
		private static readonly MessageParser<GetRogueInitialScoreCsReq> _parser = new MessageParser<GetRogueInitialScoreCsReq>(() => new GetRogueInitialScoreCsReq());

		// Token: 0x0400228C RID: 8844
		private UnknownFieldSet _unknownFields;
	}
}
