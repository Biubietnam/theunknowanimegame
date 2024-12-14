using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001339 RID: 4921
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeTalkRewardCsReq : IMessage<TakeTalkRewardCsReq>, IMessage, IEquatable<TakeTalkRewardCsReq>, IDeepCloneable<TakeTalkRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003DB2 RID: 15794
		// (get) Token: 0x0600DB9B RID: 56219 RVA: 0x00248EE1 File Offset: 0x002470E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeTalkRewardCsReq> Parser
		{
			get
			{
				return TakeTalkRewardCsReq._parser;
			}
		}

		// Token: 0x17003DB3 RID: 15795
		// (get) Token: 0x0600DB9C RID: 56220 RVA: 0x00248EE8 File Offset: 0x002470E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeTalkRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003DB4 RID: 15796
		// (get) Token: 0x0600DB9D RID: 56221 RVA: 0x00248EFA File Offset: 0x002470FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeTalkRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600DB9E RID: 56222 RVA: 0x00248F01 File Offset: 0x00247101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTalkRewardCsReq()
		{
		}

		// Token: 0x0600DB9F RID: 56223 RVA: 0x00248F0C File Offset: 0x0024710C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTalkRewardCsReq(TakeTalkRewardCsReq other) : this()
		{
			this.mMKIANLHPLJ_ = other.mMKIANLHPLJ_;
			this.pMNKHIDJALM_ = ((other.pMNKHIDJALM_ != null) ? other.pMNKHIDJALM_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DBA0 RID: 56224 RVA: 0x00248F58 File Offset: 0x00247158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeTalkRewardCsReq Clone()
		{
			return new TakeTalkRewardCsReq(this);
		}

		// Token: 0x17003DB5 RID: 15797
		// (get) Token: 0x0600DBA1 RID: 56225 RVA: 0x00248F60 File Offset: 0x00247160
		// (set) Token: 0x0600DBA2 RID: 56226 RVA: 0x00248F68 File Offset: 0x00247168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MMKIANLHPLJ
		{
			get
			{
				return this.mMKIANLHPLJ_;
			}
			set
			{
				this.mMKIANLHPLJ_ = value;
			}
		}

		// Token: 0x17003DB6 RID: 15798
		// (get) Token: 0x0600DBA3 RID: 56227 RVA: 0x00248F71 File Offset: 0x00247171
		// (set) Token: 0x0600DBA4 RID: 56228 RVA: 0x00248F79 File Offset: 0x00247179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector PMNKHIDJALM
		{
			get
			{
				return this.pMNKHIDJALM_;
			}
			set
			{
				this.pMNKHIDJALM_ = value;
			}
		}

		// Token: 0x0600DBA5 RID: 56229 RVA: 0x00248F82 File Offset: 0x00247182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeTalkRewardCsReq);
		}

		// Token: 0x0600DBA6 RID: 56230 RVA: 0x00248F90 File Offset: 0x00247190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeTalkRewardCsReq other)
		{
			return other != null && (other == this || (this.MMKIANLHPLJ == other.MMKIANLHPLJ && object.Equals(this.PMNKHIDJALM, other.PMNKHIDJALM) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DBA7 RID: 56231 RVA: 0x00248FE0 File Offset: 0x002471E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MMKIANLHPLJ != 0U)
			{
				num ^= this.MMKIANLHPLJ.GetHashCode();
			}
			if (this.pMNKHIDJALM_ != null)
			{
				num ^= this.PMNKHIDJALM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DBA8 RID: 56232 RVA: 0x00249035 File Offset: 0x00247235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DBA9 RID: 56233 RVA: 0x0024903D File Offset: 0x0024723D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DBAA RID: 56234 RVA: 0x00249048 File Offset: 0x00247248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pMNKHIDJALM_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.PMNKHIDJALM);
			}
			if (this.MMKIANLHPLJ != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.MMKIANLHPLJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DBAB RID: 56235 RVA: 0x002490A4 File Offset: 0x002472A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MMKIANLHPLJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MMKIANLHPLJ);
			}
			if (this.pMNKHIDJALM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PMNKHIDJALM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DBAC RID: 56236 RVA: 0x002490FC File Offset: 0x002472FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeTalkRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MMKIANLHPLJ != 0U)
			{
				this.MMKIANLHPLJ = other.MMKIANLHPLJ;
			}
			if (other.pMNKHIDJALM_ != null)
			{
				if (this.pMNKHIDJALM_ == null)
				{
					this.PMNKHIDJALM = new Vector();
				}
				this.PMNKHIDJALM.MergeFrom(other.PMNKHIDJALM);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DBAD RID: 56237 RVA: 0x00249164 File Offset: 0x00247364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DBAE RID: 56238 RVA: 0x00249170 File Offset: 0x00247370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MMKIANLHPLJ = input.ReadUInt32();
					}
				}
				else
				{
					if (this.pMNKHIDJALM_ == null)
					{
						this.PMNKHIDJALM = new Vector();
					}
					input.ReadMessage(this.PMNKHIDJALM);
				}
			}
		}

		// Token: 0x0400576D RID: 22381
		private static readonly MessageParser<TakeTalkRewardCsReq> _parser = new MessageParser<TakeTalkRewardCsReq>(() => new TakeTalkRewardCsReq());

		// Token: 0x0400576E RID: 22382
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400576F RID: 22383
		public const int MMKIANLHPLJFieldNumber = 12;

		// Token: 0x04005770 RID: 22384
		private uint mMKIANLHPLJ_;

		// Token: 0x04005771 RID: 22385
		public const int PMNKHIDJALMFieldNumber = 3;

		// Token: 0x04005772 RID: 22386
		private Vector pMNKHIDJALM_;
	}
}
