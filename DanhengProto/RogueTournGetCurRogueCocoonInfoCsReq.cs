using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FC9 RID: 4041
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournGetCurRogueCocoonInfoCsReq : IMessage<RogueTournGetCurRogueCocoonInfoCsReq>, IMessage, IEquatable<RogueTournGetCurRogueCocoonInfoCsReq>, IDeepCloneable<RogueTournGetCurRogueCocoonInfoCsReq>, IBufferMessage
	{
		// Token: 0x170032BD RID: 12989
		// (get) Token: 0x0600B404 RID: 46084 RVA: 0x001E33DB File Offset: 0x001E15DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournGetCurRogueCocoonInfoCsReq> Parser
		{
			get
			{
				return RogueTournGetCurRogueCocoonInfoCsReq._parser;
			}
		}

		// Token: 0x170032BE RID: 12990
		// (get) Token: 0x0600B405 RID: 46085 RVA: 0x001E33E2 File Offset: 0x001E15E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournGetCurRogueCocoonInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032BF RID: 12991
		// (get) Token: 0x0600B406 RID: 46086 RVA: 0x001E33F4 File Offset: 0x001E15F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournGetCurRogueCocoonInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600B407 RID: 46087 RVA: 0x001E33FB File Offset: 0x001E15FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetCurRogueCocoonInfoCsReq()
		{
		}

		// Token: 0x0600B408 RID: 46088 RVA: 0x001E3403 File Offset: 0x001E1603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetCurRogueCocoonInfoCsReq(RogueTournGetCurRogueCocoonInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B409 RID: 46089 RVA: 0x001E341C File Offset: 0x001E161C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetCurRogueCocoonInfoCsReq Clone()
		{
			return new RogueTournGetCurRogueCocoonInfoCsReq(this);
		}

		// Token: 0x0600B40A RID: 46090 RVA: 0x001E3424 File Offset: 0x001E1624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournGetCurRogueCocoonInfoCsReq);
		}

		// Token: 0x0600B40B RID: 46091 RVA: 0x001E3432 File Offset: 0x001E1632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournGetCurRogueCocoonInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B40C RID: 46092 RVA: 0x001E3450 File Offset: 0x001E1650
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

		// Token: 0x0600B40D RID: 46093 RVA: 0x001E3476 File Offset: 0x001E1676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B40E RID: 46094 RVA: 0x001E347E File Offset: 0x001E167E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B40F RID: 46095 RVA: 0x001E3487 File Offset: 0x001E1687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B410 RID: 46096 RVA: 0x001E34A0 File Offset: 0x001E16A0
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

		// Token: 0x0600B411 RID: 46097 RVA: 0x001E34C6 File Offset: 0x001E16C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournGetCurRogueCocoonInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B412 RID: 46098 RVA: 0x001E34E3 File Offset: 0x001E16E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B413 RID: 46099 RVA: 0x001E34EC File Offset: 0x001E16EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004905 RID: 18693
		private static readonly MessageParser<RogueTournGetCurRogueCocoonInfoCsReq> _parser = new MessageParser<RogueTournGetCurRogueCocoonInfoCsReq>(() => new RogueTournGetCurRogueCocoonInfoCsReq());

		// Token: 0x04004906 RID: 18694
		private UnknownFieldSet _unknownFields;
	}
}
