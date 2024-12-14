using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FBD RID: 4029
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournGameAreaInfo : IMessage<RogueTournGameAreaInfo>, IMessage, IEquatable<RogueTournGameAreaInfo>, IDeepCloneable<RogueTournGameAreaInfo>, IBufferMessage
	{
		// Token: 0x1700329D RID: 12957
		// (get) Token: 0x0600B386 RID: 45958 RVA: 0x001E2355 File Offset: 0x001E0555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournGameAreaInfo> Parser
		{
			get
			{
				return RogueTournGameAreaInfo._parser;
			}
		}

		// Token: 0x1700329E RID: 12958
		// (get) Token: 0x0600B387 RID: 45959 RVA: 0x001E235C File Offset: 0x001E055C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournGameAreaInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700329F RID: 12959
		// (get) Token: 0x0600B388 RID: 45960 RVA: 0x001E236E File Offset: 0x001E056E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournGameAreaInfo.Descriptor;
			}
		}

		// Token: 0x0600B389 RID: 45961 RVA: 0x001E2375 File Offset: 0x001E0575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGameAreaInfo()
		{
		}

		// Token: 0x0600B38A RID: 45962 RVA: 0x001E237D File Offset: 0x001E057D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGameAreaInfo(RogueTournGameAreaInfo other) : this()
		{
			this.gameWeek_ = other.gameWeek_;
			this.gameAreaId_ = other.gameAreaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B38B RID: 45963 RVA: 0x001E23AE File Offset: 0x001E05AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournGameAreaInfo Clone()
		{
			return new RogueTournGameAreaInfo(this);
		}

		// Token: 0x170032A0 RID: 12960
		// (get) Token: 0x0600B38C RID: 45964 RVA: 0x001E23B6 File Offset: 0x001E05B6
		// (set) Token: 0x0600B38D RID: 45965 RVA: 0x001E23BE File Offset: 0x001E05BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameWeek
		{
			get
			{
				return this.gameWeek_;
			}
			set
			{
				this.gameWeek_ = value;
			}
		}

		// Token: 0x170032A1 RID: 12961
		// (get) Token: 0x0600B38E RID: 45966 RVA: 0x001E23C7 File Offset: 0x001E05C7
		// (set) Token: 0x0600B38F RID: 45967 RVA: 0x001E23CF File Offset: 0x001E05CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameAreaId
		{
			get
			{
				return this.gameAreaId_;
			}
			set
			{
				this.gameAreaId_ = value;
			}
		}

		// Token: 0x0600B390 RID: 45968 RVA: 0x001E23D8 File Offset: 0x001E05D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournGameAreaInfo);
		}

		// Token: 0x0600B391 RID: 45969 RVA: 0x001E23E6 File Offset: 0x001E05E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournGameAreaInfo other)
		{
			return other != null && (other == this || (this.GameWeek == other.GameWeek && this.GameAreaId == other.GameAreaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B392 RID: 45970 RVA: 0x001E2424 File Offset: 0x001E0624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GameWeek != 0U)
			{
				num ^= this.GameWeek.GetHashCode();
			}
			if (this.GameAreaId != 0U)
			{
				num ^= this.GameAreaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B393 RID: 45971 RVA: 0x001E247C File Offset: 0x001E067C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B394 RID: 45972 RVA: 0x001E2484 File Offset: 0x001E0684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B395 RID: 45973 RVA: 0x001E2490 File Offset: 0x001E0690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GameAreaId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.GameAreaId);
			}
			if (this.GameWeek != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.GameWeek);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B396 RID: 45974 RVA: 0x001E24EC File Offset: 0x001E06EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GameWeek != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameWeek);
			}
			if (this.GameAreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAreaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B397 RID: 45975 RVA: 0x001E2544 File Offset: 0x001E0744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournGameAreaInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GameWeek != 0U)
			{
				this.GameWeek = other.GameWeek;
			}
			if (other.GameAreaId != 0U)
			{
				this.GameAreaId = other.GameAreaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B398 RID: 45976 RVA: 0x001E2594 File Offset: 0x001E0794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B399 RID: 45977 RVA: 0x001E25A0 File Offset: 0x001E07A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GameWeek = input.ReadUInt32();
					}
				}
				else
				{
					this.GameAreaId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040048DF RID: 18655
		private static readonly MessageParser<RogueTournGameAreaInfo> _parser = new MessageParser<RogueTournGameAreaInfo>(() => new RogueTournGameAreaInfo());

		// Token: 0x040048E0 RID: 18656
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048E1 RID: 18657
		public const int GameWeekFieldNumber = 6;

		// Token: 0x040048E2 RID: 18658
		private uint gameWeek_;

		// Token: 0x040048E3 RID: 18659
		public const int GameAreaIdFieldNumber = 4;

		// Token: 0x040048E4 RID: 18660
		private uint gameAreaId_;
	}
}
