using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003C1 RID: 961
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DoGachaCsReq : IMessage<DoGachaCsReq>, IMessage, IEquatable<DoGachaCsReq>, IDeepCloneable<DoGachaCsReq>, IBufferMessage
	{
		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06002AB2 RID: 10930 RVA: 0x00076FAD File Offset: 0x000751AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DoGachaCsReq> Parser
		{
			get
			{
				return DoGachaCsReq._parser;
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06002AB3 RID: 10931 RVA: 0x00076FB4 File Offset: 0x000751B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DoGachaCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06002AB4 RID: 10932 RVA: 0x00076FC6 File Offset: 0x000751C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DoGachaCsReq.Descriptor;
			}
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x00076FCD File Offset: 0x000751CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoGachaCsReq()
		{
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x00076FD8 File Offset: 0x000751D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoGachaCsReq(DoGachaCsReq other) : this()
		{
			this.gachaId_ = other.gachaId_;
			this.simulateMagic_ = other.simulateMagic_;
			this.gachaNum_ = other.gachaNum_;
			this.gachaRandom_ = other.gachaRandom_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x0007702C File Offset: 0x0007522C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoGachaCsReq Clone()
		{
			return new DoGachaCsReq(this);
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06002AB8 RID: 10936 RVA: 0x00077034 File Offset: 0x00075234
		// (set) Token: 0x06002AB9 RID: 10937 RVA: 0x0007703C File Offset: 0x0007523C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GachaId
		{
			get
			{
				return this.gachaId_;
			}
			set
			{
				this.gachaId_ = value;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06002ABA RID: 10938 RVA: 0x00077045 File Offset: 0x00075245
		// (set) Token: 0x06002ABB RID: 10939 RVA: 0x0007704D File Offset: 0x0007524D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SimulateMagic
		{
			get
			{
				return this.simulateMagic_;
			}
			set
			{
				this.simulateMagic_ = value;
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06002ABC RID: 10940 RVA: 0x00077056 File Offset: 0x00075256
		// (set) Token: 0x06002ABD RID: 10941 RVA: 0x0007705E File Offset: 0x0007525E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GachaNum
		{
			get
			{
				return this.gachaNum_;
			}
			set
			{
				this.gachaNum_ = value;
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06002ABE RID: 10942 RVA: 0x00077067 File Offset: 0x00075267
		// (set) Token: 0x06002ABF RID: 10943 RVA: 0x0007706F File Offset: 0x0007526F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GachaRandom
		{
			get
			{
				return this.gachaRandom_;
			}
			set
			{
				this.gachaRandom_ = value;
			}
		}

		// Token: 0x06002AC0 RID: 10944 RVA: 0x00077078 File Offset: 0x00075278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DoGachaCsReq);
		}

		// Token: 0x06002AC1 RID: 10945 RVA: 0x00077088 File Offset: 0x00075288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DoGachaCsReq other)
		{
			return other != null && (other == this || (this.GachaId == other.GachaId && this.SimulateMagic == other.SimulateMagic && this.GachaNum == other.GachaNum && this.GachaRandom == other.GachaRandom && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002AC2 RID: 10946 RVA: 0x000770F4 File Offset: 0x000752F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaId != 0U)
			{
				num ^= this.GachaId.GetHashCode();
			}
			if (this.SimulateMagic != 0U)
			{
				num ^= this.SimulateMagic.GetHashCode();
			}
			if (this.GachaNum != 0U)
			{
				num ^= this.GachaNum.GetHashCode();
			}
			if (this.GachaRandom != 0U)
			{
				num ^= this.GachaRandom.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002AC3 RID: 10947 RVA: 0x0007717E File Offset: 0x0007537E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002AC4 RID: 10948 RVA: 0x00077186 File Offset: 0x00075386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x00077190 File Offset: 0x00075390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SimulateMagic != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.SimulateMagic);
			}
			if (this.GachaId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.GachaId);
			}
			if (this.GachaNum != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.GachaNum);
			}
			if (this.GachaRandom != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.GachaRandom);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x00077220 File Offset: 0x00075420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GachaId);
			}
			if (this.SimulateMagic != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SimulateMagic);
			}
			if (this.GachaNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GachaNum);
			}
			if (this.GachaRandom != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GachaRandom);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x000772A8 File Offset: 0x000754A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DoGachaCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaId != 0U)
			{
				this.GachaId = other.GachaId;
			}
			if (other.SimulateMagic != 0U)
			{
				this.SimulateMagic = other.SimulateMagic;
			}
			if (other.GachaNum != 0U)
			{
				this.GachaNum = other.GachaNum;
			}
			if (other.GachaRandom != 0U)
			{
				this.GachaRandom = other.GachaRandom;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x00077320 File Offset: 0x00075520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002AC9 RID: 10953 RVA: 0x0007732C File Offset: 0x0007552C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.SimulateMagic = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.GachaId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.GachaNum = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.GachaRandom = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001152 RID: 4434
		private static readonly MessageParser<DoGachaCsReq> _parser = new MessageParser<DoGachaCsReq>(() => new DoGachaCsReq());

		// Token: 0x04001153 RID: 4435
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001154 RID: 4436
		public const int GachaIdFieldNumber = 2;

		// Token: 0x04001155 RID: 4437
		private uint gachaId_;

		// Token: 0x04001156 RID: 4438
		public const int SimulateMagicFieldNumber = 1;

		// Token: 0x04001157 RID: 4439
		private uint simulateMagic_;

		// Token: 0x04001158 RID: 4440
		public const int GachaNumFieldNumber = 4;

		// Token: 0x04001159 RID: 4441
		private uint gachaNum_;

		// Token: 0x0400115A RID: 4442
		public const int GachaRandomFieldNumber = 5;

		// Token: 0x0400115B RID: 4443
		private uint gachaRandom_;
	}
}
