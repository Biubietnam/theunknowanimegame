using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FC1 RID: 4033
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournGetAllArchiveCsReq : IMessage<RogueTournGetAllArchiveCsReq>, IMessage, IEquatable<RogueTournGetAllArchiveCsReq>, IDeepCloneable<RogueTournGetAllArchiveCsReq>, IBufferMessage
	{
		// Token: 0x170032A8 RID: 12968
		// (get) Token: 0x0600B3B1 RID: 46001 RVA: 0x001E28E7 File Offset: 0x001E0AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournGetAllArchiveCsReq> Parser
		{
			get
			{
				return RogueTournGetAllArchiveCsReq._parser;
			}
		}

		// Token: 0x170032A9 RID: 12969
		// (get) Token: 0x0600B3B2 RID: 46002 RVA: 0x001E28EE File Offset: 0x001E0AEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournGetAllArchiveCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032AA RID: 12970
		// (get) Token: 0x0600B3B3 RID: 46003 RVA: 0x001E2900 File Offset: 0x001E0B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournGetAllArchiveCsReq.Descriptor;
			}
		}

		// Token: 0x0600B3B4 RID: 46004 RVA: 0x001E2907 File Offset: 0x001E0B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetAllArchiveCsReq()
		{
		}

		// Token: 0x0600B3B5 RID: 46005 RVA: 0x001E290F File Offset: 0x001E0B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetAllArchiveCsReq(RogueTournGetAllArchiveCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3B6 RID: 46006 RVA: 0x001E2928 File Offset: 0x001E0B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetAllArchiveCsReq Clone()
		{
			return new RogueTournGetAllArchiveCsReq(this);
		}

		// Token: 0x0600B3B7 RID: 46007 RVA: 0x001E2930 File Offset: 0x001E0B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournGetAllArchiveCsReq);
		}

		// Token: 0x0600B3B8 RID: 46008 RVA: 0x001E293E File Offset: 0x001E0B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournGetAllArchiveCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B3B9 RID: 46009 RVA: 0x001E295C File Offset: 0x001E0B5C
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

		// Token: 0x0600B3BA RID: 46010 RVA: 0x001E2982 File Offset: 0x001E0B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B3BB RID: 46011 RVA: 0x001E298A File Offset: 0x001E0B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3BC RID: 46012 RVA: 0x001E2993 File Offset: 0x001E0B93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3BD RID: 46013 RVA: 0x001E29AC File Offset: 0x001E0BAC
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

		// Token: 0x0600B3BE RID: 46014 RVA: 0x001E29D2 File Offset: 0x001E0BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournGetAllArchiveCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B3BF RID: 46015 RVA: 0x001E29EF File Offset: 0x001E0BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3C0 RID: 46016 RVA: 0x001E29F8 File Offset: 0x001E0BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040048EC RID: 18668
		private static readonly MessageParser<RogueTournGetAllArchiveCsReq> _parser = new MessageParser<RogueTournGetAllArchiveCsReq>(() => new RogueTournGetAllArchiveCsReq());

		// Token: 0x040048ED RID: 18669
		private UnknownFieldSet _unknownFields;
	}
}
