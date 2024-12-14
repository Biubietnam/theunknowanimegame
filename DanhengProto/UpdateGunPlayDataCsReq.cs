using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013DB RID: 5083
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateGunPlayDataCsReq : IMessage<UpdateGunPlayDataCsReq>, IMessage, IEquatable<UpdateGunPlayDataCsReq>, IDeepCloneable<UpdateGunPlayDataCsReq>, IBufferMessage
	{
		// Token: 0x17003F9F RID: 16287
		// (get) Token: 0x0600E292 RID: 58002 RVA: 0x0025A8FF File Offset: 0x00258AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateGunPlayDataCsReq> Parser
		{
			get
			{
				return UpdateGunPlayDataCsReq._parser;
			}
		}

		// Token: 0x17003FA0 RID: 16288
		// (get) Token: 0x0600E293 RID: 58003 RVA: 0x0025A906 File Offset: 0x00258B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateGunPlayDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003FA1 RID: 16289
		// (get) Token: 0x0600E294 RID: 58004 RVA: 0x0025A918 File Offset: 0x00258B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateGunPlayDataCsReq.Descriptor;
			}
		}

		// Token: 0x0600E295 RID: 58005 RVA: 0x0025A91F File Offset: 0x00258B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateGunPlayDataCsReq()
		{
		}

		// Token: 0x0600E296 RID: 58006 RVA: 0x0025A928 File Offset: 0x00258B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateGunPlayDataCsReq(UpdateGunPlayDataCsReq other) : this()
		{
			this.groupId_ = other.groupId_;
			this.nIEPAOBBFJF_ = other.nIEPAOBBFJF_;
			this.gHCJKLFLCEM_ = ((other.gHCJKLFLCEM_ != null) ? other.gHCJKLFLCEM_.Clone() : null);
			this.lMGBJJKFLKK_ = other.lMGBJJKFLKK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E297 RID: 58007 RVA: 0x0025A98C File Offset: 0x00258B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateGunPlayDataCsReq Clone()
		{
			return new UpdateGunPlayDataCsReq(this);
		}

		// Token: 0x17003FA2 RID: 16290
		// (get) Token: 0x0600E298 RID: 58008 RVA: 0x0025A994 File Offset: 0x00258B94
		// (set) Token: 0x0600E299 RID: 58009 RVA: 0x0025A99C File Offset: 0x00258B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17003FA3 RID: 16291
		// (get) Token: 0x0600E29A RID: 58010 RVA: 0x0025A9A5 File Offset: 0x00258BA5
		// (set) Token: 0x0600E29B RID: 58011 RVA: 0x0025A9AD File Offset: 0x00258BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong NIEPAOBBFJF
		{
			get
			{
				return this.nIEPAOBBFJF_;
			}
			set
			{
				this.nIEPAOBBFJF_ = value;
			}
		}

		// Token: 0x17003FA4 RID: 16292
		// (get) Token: 0x0600E29C RID: 58012 RVA: 0x0025A9B6 File Offset: 0x00258BB6
		// (set) Token: 0x0600E29D RID: 58013 RVA: 0x0025A9BE File Offset: 0x00258BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NNEOOKDGDIK GHCJKLFLCEM
		{
			get
			{
				return this.gHCJKLFLCEM_;
			}
			set
			{
				this.gHCJKLFLCEM_ = value;
			}
		}

		// Token: 0x17003FA5 RID: 16293
		// (get) Token: 0x0600E29E RID: 58014 RVA: 0x0025A9C7 File Offset: 0x00258BC7
		// (set) Token: 0x0600E29F RID: 58015 RVA: 0x0025A9CF File Offset: 0x00258BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LMGBJJKFLKK
		{
			get
			{
				return this.lMGBJJKFLKK_;
			}
			set
			{
				this.lMGBJJKFLKK_ = value;
			}
		}

		// Token: 0x0600E2A0 RID: 58016 RVA: 0x0025A9D8 File Offset: 0x00258BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateGunPlayDataCsReq);
		}

		// Token: 0x0600E2A1 RID: 58017 RVA: 0x0025A9E8 File Offset: 0x00258BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateGunPlayDataCsReq other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.NIEPAOBBFJF == other.NIEPAOBBFJF && object.Equals(this.GHCJKLFLCEM, other.GHCJKLFLCEM) && this.LMGBJJKFLKK == other.LMGBJJKFLKK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E2A2 RID: 58018 RVA: 0x0025AA58 File Offset: 0x00258C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.NIEPAOBBFJF != 0UL)
			{
				num ^= this.NIEPAOBBFJF.GetHashCode();
			}
			if (this.gHCJKLFLCEM_ != null)
			{
				num ^= this.GHCJKLFLCEM.GetHashCode();
			}
			if (this.LMGBJJKFLKK != 0U)
			{
				num ^= this.LMGBJJKFLKK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E2A3 RID: 58019 RVA: 0x0025AADF File Offset: 0x00258CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E2A4 RID: 58020 RVA: 0x0025AAE7 File Offset: 0x00258CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E2A5 RID: 58021 RVA: 0x0025AAF0 File Offset: 0x00258CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NIEPAOBBFJF != 0UL)
			{
				output.WriteRawTag(56);
				output.WriteUInt64(this.NIEPAOBBFJF);
			}
			if (this.LMGBJJKFLKK != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.LMGBJJKFLKK);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.GroupId);
			}
			if (this.gHCJKLFLCEM_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.GHCJKLFLCEM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E2A6 RID: 58022 RVA: 0x0025AB84 File Offset: 0x00258D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.NIEPAOBBFJF != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.NIEPAOBBFJF);
			}
			if (this.gHCJKLFLCEM_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GHCJKLFLCEM);
			}
			if (this.LMGBJJKFLKK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LMGBJJKFLKK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E2A7 RID: 58023 RVA: 0x0025AC0C File Offset: 0x00258E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateGunPlayDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.NIEPAOBBFJF != 0UL)
			{
				this.NIEPAOBBFJF = other.NIEPAOBBFJF;
			}
			if (other.gHCJKLFLCEM_ != null)
			{
				if (this.gHCJKLFLCEM_ == null)
				{
					this.GHCJKLFLCEM = new NNEOOKDGDIK();
				}
				this.GHCJKLFLCEM.MergeFrom(other.GHCJKLFLCEM);
			}
			if (other.LMGBJJKFLKK != 0U)
			{
				this.LMGBJJKFLKK = other.LMGBJJKFLKK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E2A8 RID: 58024 RVA: 0x0025AC9C File Offset: 0x00258E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E2A9 RID: 58025 RVA: 0x0025ACA8 File Offset: 0x00258EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 56U)
					{
						this.NIEPAOBBFJF = input.ReadUInt64();
						continue;
					}
					if (num == 64U)
					{
						this.LMGBJJKFLKK = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						if (this.gHCJKLFLCEM_ == null)
						{
							this.GHCJKLFLCEM = new NNEOOKDGDIK();
						}
						input.ReadMessage(this.GHCJKLFLCEM);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005A18 RID: 23064
		private static readonly MessageParser<UpdateGunPlayDataCsReq> _parser = new MessageParser<UpdateGunPlayDataCsReq>(() => new UpdateGunPlayDataCsReq());

		// Token: 0x04005A19 RID: 23065
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A1A RID: 23066
		public const int GroupIdFieldNumber = 9;

		// Token: 0x04005A1B RID: 23067
		private uint groupId_;

		// Token: 0x04005A1C RID: 23068
		public const int NIEPAOBBFJFFieldNumber = 7;

		// Token: 0x04005A1D RID: 23069
		private ulong nIEPAOBBFJF_;

		// Token: 0x04005A1E RID: 23070
		public const int GHCJKLFLCEMFieldNumber = 13;

		// Token: 0x04005A1F RID: 23071
		private NNEOOKDGDIK gHCJKLFLCEM_;

		// Token: 0x04005A20 RID: 23072
		public const int LMGBJJKFLKKFieldNumber = 8;

		// Token: 0x04005A21 RID: 23073
		private uint lMGBJJKFLKK_;
	}
}
