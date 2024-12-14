using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001311 RID: 4881
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakePunkLordPointRewardCsReq : IMessage<TakePunkLordPointRewardCsReq>, IMessage, IEquatable<TakePunkLordPointRewardCsReq>, IDeepCloneable<TakePunkLordPointRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003D2E RID: 15662
		// (get) Token: 0x0600D9C0 RID: 55744 RVA: 0x002441D9 File Offset: 0x002423D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakePunkLordPointRewardCsReq> Parser
		{
			get
			{
				return TakePunkLordPointRewardCsReq._parser;
			}
		}

		// Token: 0x17003D2F RID: 15663
		// (get) Token: 0x0600D9C1 RID: 55745 RVA: 0x002441E0 File Offset: 0x002423E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakePunkLordPointRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D30 RID: 15664
		// (get) Token: 0x0600D9C2 RID: 55746 RVA: 0x002441F2 File Offset: 0x002423F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakePunkLordPointRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D9C3 RID: 55747 RVA: 0x002441F9 File Offset: 0x002423F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePunkLordPointRewardCsReq()
		{
		}

		// Token: 0x0600D9C4 RID: 55748 RVA: 0x00244201 File Offset: 0x00242401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePunkLordPointRewardCsReq(TakePunkLordPointRewardCsReq other) : this()
		{
			this.level_ = other.level_;
			this.mGCIACFKBFM_ = other.mGCIACFKBFM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D9C5 RID: 55749 RVA: 0x00244232 File Offset: 0x00242432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePunkLordPointRewardCsReq Clone()
		{
			return new TakePunkLordPointRewardCsReq(this);
		}

		// Token: 0x17003D31 RID: 15665
		// (get) Token: 0x0600D9C6 RID: 55750 RVA: 0x0024423A File Offset: 0x0024243A
		// (set) Token: 0x0600D9C7 RID: 55751 RVA: 0x00244242 File Offset: 0x00242442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17003D32 RID: 15666
		// (get) Token: 0x0600D9C8 RID: 55752 RVA: 0x0024424B File Offset: 0x0024244B
		// (set) Token: 0x0600D9C9 RID: 55753 RVA: 0x00244253 File Offset: 0x00242453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MGCIACFKBFM
		{
			get
			{
				return this.mGCIACFKBFM_;
			}
			set
			{
				this.mGCIACFKBFM_ = value;
			}
		}

		// Token: 0x0600D9CA RID: 55754 RVA: 0x0024425C File Offset: 0x0024245C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakePunkLordPointRewardCsReq);
		}

		// Token: 0x0600D9CB RID: 55755 RVA: 0x0024426A File Offset: 0x0024246A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakePunkLordPointRewardCsReq other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.MGCIACFKBFM == other.MGCIACFKBFM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D9CC RID: 55756 RVA: 0x002442A8 File Offset: 0x002424A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.MGCIACFKBFM)
			{
				num ^= this.MGCIACFKBFM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D9CD RID: 55757 RVA: 0x00244300 File Offset: 0x00242500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D9CE RID: 55758 RVA: 0x00244308 File Offset: 0x00242508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D9CF RID: 55759 RVA: 0x00244314 File Offset: 0x00242514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MGCIACFKBFM)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.MGCIACFKBFM);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D9D0 RID: 55760 RVA: 0x00244370 File Offset: 0x00242570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.MGCIACFKBFM)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D9D1 RID: 55761 RVA: 0x002443BC File Offset: 0x002425BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakePunkLordPointRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.MGCIACFKBFM)
			{
				this.MGCIACFKBFM = other.MGCIACFKBFM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D9D2 RID: 55762 RVA: 0x0024440C File Offset: 0x0024260C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D9D3 RID: 55763 RVA: 0x00244418 File Offset: 0x00242618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Level = input.ReadUInt32();
					}
				}
				else
				{
					this.MGCIACFKBFM = input.ReadBool();
				}
			}
		}

		// Token: 0x040056C0 RID: 22208
		private static readonly MessageParser<TakePunkLordPointRewardCsReq> _parser = new MessageParser<TakePunkLordPointRewardCsReq>(() => new TakePunkLordPointRewardCsReq());

		// Token: 0x040056C1 RID: 22209
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056C2 RID: 22210
		public const int LevelFieldNumber = 5;

		// Token: 0x040056C3 RID: 22211
		private uint level_;

		// Token: 0x040056C4 RID: 22212
		public const int MGCIACFKBFMFieldNumber = 2;

		// Token: 0x040056C5 RID: 22213
		private bool mGCIACFKBFM_;
	}
}
