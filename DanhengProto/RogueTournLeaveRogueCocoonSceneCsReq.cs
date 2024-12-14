using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FE5 RID: 4069
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournLeaveRogueCocoonSceneCsReq : IMessage<RogueTournLeaveRogueCocoonSceneCsReq>, IMessage, IEquatable<RogueTournLeaveRogueCocoonSceneCsReq>, IDeepCloneable<RogueTournLeaveRogueCocoonSceneCsReq>, IBufferMessage
	{
		// Token: 0x1700330C RID: 13068
		// (get) Token: 0x0600B51D RID: 46365 RVA: 0x001E6343 File Offset: 0x001E4543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournLeaveRogueCocoonSceneCsReq> Parser
		{
			get
			{
				return RogueTournLeaveRogueCocoonSceneCsReq._parser;
			}
		}

		// Token: 0x1700330D RID: 13069
		// (get) Token: 0x0600B51E RID: 46366 RVA: 0x001E634A File Offset: 0x001E454A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournLeaveRogueCocoonSceneCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700330E RID: 13070
		// (get) Token: 0x0600B51F RID: 46367 RVA: 0x001E635C File Offset: 0x001E455C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournLeaveRogueCocoonSceneCsReq.Descriptor;
			}
		}

		// Token: 0x0600B520 RID: 46368 RVA: 0x001E6363 File Offset: 0x001E4563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLeaveRogueCocoonSceneCsReq()
		{
		}

		// Token: 0x0600B521 RID: 46369 RVA: 0x001E636B File Offset: 0x001E456B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLeaveRogueCocoonSceneCsReq(RogueTournLeaveRogueCocoonSceneCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B522 RID: 46370 RVA: 0x001E6384 File Offset: 0x001E4584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournLeaveRogueCocoonSceneCsReq Clone()
		{
			return new RogueTournLeaveRogueCocoonSceneCsReq(this);
		}

		// Token: 0x0600B523 RID: 46371 RVA: 0x001E638C File Offset: 0x001E458C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournLeaveRogueCocoonSceneCsReq);
		}

		// Token: 0x0600B524 RID: 46372 RVA: 0x001E639A File Offset: 0x001E459A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournLeaveRogueCocoonSceneCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B525 RID: 46373 RVA: 0x001E63B8 File Offset: 0x001E45B8
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

		// Token: 0x0600B526 RID: 46374 RVA: 0x001E63DE File Offset: 0x001E45DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B527 RID: 46375 RVA: 0x001E63E6 File Offset: 0x001E45E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B528 RID: 46376 RVA: 0x001E63EF File Offset: 0x001E45EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B529 RID: 46377 RVA: 0x001E6408 File Offset: 0x001E4608
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

		// Token: 0x0600B52A RID: 46378 RVA: 0x001E642E File Offset: 0x001E462E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournLeaveRogueCocoonSceneCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B52B RID: 46379 RVA: 0x001E644B File Offset: 0x001E464B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B52C RID: 46380 RVA: 0x001E6454 File Offset: 0x001E4654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004979 RID: 18809
		private static readonly MessageParser<RogueTournLeaveRogueCocoonSceneCsReq> _parser = new MessageParser<RogueTournLeaveRogueCocoonSceneCsReq>(() => new RogueTournLeaveRogueCocoonSceneCsReq());

		// Token: 0x0400497A RID: 18810
		private UnknownFieldSet _unknownFields;
	}
}
