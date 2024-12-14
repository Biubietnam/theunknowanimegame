using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FD1 RID: 4049
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournGetPermanentTalentInfoCsReq : IMessage<RogueTournGetPermanentTalentInfoCsReq>, IMessage, IEquatable<RogueTournGetPermanentTalentInfoCsReq>, IDeepCloneable<RogueTournGetPermanentTalentInfoCsReq>, IBufferMessage
	{
		// Token: 0x170032D5 RID: 13013
		// (get) Token: 0x0600B460 RID: 46176 RVA: 0x001E41B3 File Offset: 0x001E23B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournGetPermanentTalentInfoCsReq> Parser
		{
			get
			{
				return RogueTournGetPermanentTalentInfoCsReq._parser;
			}
		}

		// Token: 0x170032D6 RID: 13014
		// (get) Token: 0x0600B461 RID: 46177 RVA: 0x001E41BA File Offset: 0x001E23BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournGetPermanentTalentInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170032D7 RID: 13015
		// (get) Token: 0x0600B462 RID: 46178 RVA: 0x001E41CC File Offset: 0x001E23CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournGetPermanentTalentInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600B463 RID: 46179 RVA: 0x001E41D3 File Offset: 0x001E23D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetPermanentTalentInfoCsReq()
		{
		}

		// Token: 0x0600B464 RID: 46180 RVA: 0x001E41DB File Offset: 0x001E23DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetPermanentTalentInfoCsReq(RogueTournGetPermanentTalentInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B465 RID: 46181 RVA: 0x001E41F4 File Offset: 0x001E23F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGetPermanentTalentInfoCsReq Clone()
		{
			return new RogueTournGetPermanentTalentInfoCsReq(this);
		}

		// Token: 0x0600B466 RID: 46182 RVA: 0x001E41FC File Offset: 0x001E23FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournGetPermanentTalentInfoCsReq);
		}

		// Token: 0x0600B467 RID: 46183 RVA: 0x001E420A File Offset: 0x001E240A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournGetPermanentTalentInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B468 RID: 46184 RVA: 0x001E4228 File Offset: 0x001E2428
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

		// Token: 0x0600B469 RID: 46185 RVA: 0x001E424E File Offset: 0x001E244E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B46A RID: 46186 RVA: 0x001E4256 File Offset: 0x001E2456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B46B RID: 46187 RVA: 0x001E425F File Offset: 0x001E245F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B46C RID: 46188 RVA: 0x001E4278 File Offset: 0x001E2478
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

		// Token: 0x0600B46D RID: 46189 RVA: 0x001E429E File Offset: 0x001E249E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournGetPermanentTalentInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B46E RID: 46190 RVA: 0x001E42BB File Offset: 0x001E24BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B46F RID: 46191 RVA: 0x001E42C4 File Offset: 0x001E24C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004921 RID: 18721
		private static readonly MessageParser<RogueTournGetPermanentTalentInfoCsReq> _parser = new MessageParser<RogueTournGetPermanentTalentInfoCsReq>(() => new RogueTournGetPermanentTalentInfoCsReq());

		// Token: 0x04004922 RID: 18722
		private UnknownFieldSet _unknownFields;
	}
}
