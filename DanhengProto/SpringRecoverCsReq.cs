using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200117D RID: 4477
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpringRecoverCsReq : IMessage<SpringRecoverCsReq>, IMessage, IEquatable<SpringRecoverCsReq>, IDeepCloneable<SpringRecoverCsReq>, IBufferMessage
	{
		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x0600C7C2 RID: 51138 RVA: 0x00217FCD File Offset: 0x002161CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpringRecoverCsReq> Parser
		{
			get
			{
				return SpringRecoverCsReq._parser;
			}
		}

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x0600C7C3 RID: 51139 RVA: 0x00217FD4 File Offset: 0x002161D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpringRecoverCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x0600C7C4 RID: 51140 RVA: 0x00217FE6 File Offset: 0x002161E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringRecoverCsReq.Descriptor;
			}
		}

		// Token: 0x0600C7C5 RID: 51141 RVA: 0x00217FED File Offset: 0x002161ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverCsReq()
		{
		}

		// Token: 0x0600C7C6 RID: 51142 RVA: 0x00217FF5 File Offset: 0x002161F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverCsReq(SpringRecoverCsReq other) : this()
		{
			this.floorId_ = other.floorId_;
			this.propEntityId_ = other.propEntityId_;
			this.planeId_ = other.planeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C7C7 RID: 51143 RVA: 0x00218032 File Offset: 0x00216232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRecoverCsReq Clone()
		{
			return new SpringRecoverCsReq(this);
		}

		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x0600C7C8 RID: 51144 RVA: 0x0021803A File Offset: 0x0021623A
		// (set) Token: 0x0600C7C9 RID: 51145 RVA: 0x00218042 File Offset: 0x00216242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FloorId
		{
			get
			{
				return this.floorId_;
			}
			set
			{
				this.floorId_ = value;
			}
		}

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x0600C7CA RID: 51146 RVA: 0x0021804B File Offset: 0x0021624B
		// (set) Token: 0x0600C7CB RID: 51147 RVA: 0x00218053 File Offset: 0x00216253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PropEntityId
		{
			get
			{
				return this.propEntityId_;
			}
			set
			{
				this.propEntityId_ = value;
			}
		}

		// Token: 0x1700385C RID: 14428
		// (get) Token: 0x0600C7CC RID: 51148 RVA: 0x0021805C File Offset: 0x0021625C
		// (set) Token: 0x0600C7CD RID: 51149 RVA: 0x00218064 File Offset: 0x00216264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PlaneId
		{
			get
			{
				return this.planeId_;
			}
			set
			{
				this.planeId_ = value;
			}
		}

		// Token: 0x0600C7CE RID: 51150 RVA: 0x0021806D File Offset: 0x0021626D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringRecoverCsReq);
		}

		// Token: 0x0600C7CF RID: 51151 RVA: 0x0021807C File Offset: 0x0021627C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringRecoverCsReq other)
		{
			return other != null && (other == this || (this.FloorId == other.FloorId && this.PropEntityId == other.PropEntityId && this.PlaneId == other.PlaneId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C7D0 RID: 51152 RVA: 0x002180D8 File Offset: 0x002162D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FloorId != 0U)
			{
				num ^= this.FloorId.GetHashCode();
			}
			if (this.PropEntityId != 0U)
			{
				num ^= this.PropEntityId.GetHashCode();
			}
			if (this.PlaneId != 0U)
			{
				num ^= this.PlaneId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C7D1 RID: 51153 RVA: 0x00218149 File Offset: 0x00216349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C7D2 RID: 51154 RVA: 0x00218151 File Offset: 0x00216351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C7D3 RID: 51155 RVA: 0x0021815C File Offset: 0x0021635C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FloorId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.FloorId);
			}
			if (this.PlaneId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.PlaneId);
			}
			if (this.PropEntityId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.PropEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C7D4 RID: 51156 RVA: 0x002181D4 File Offset: 0x002163D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FloorId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FloorId);
			}
			if (this.PropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PropEntityId);
			}
			if (this.PlaneId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlaneId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C7D5 RID: 51157 RVA: 0x00218244 File Offset: 0x00216444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringRecoverCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FloorId != 0U)
			{
				this.FloorId = other.FloorId;
			}
			if (other.PropEntityId != 0U)
			{
				this.PropEntityId = other.PropEntityId;
			}
			if (other.PlaneId != 0U)
			{
				this.PlaneId = other.PlaneId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C7D6 RID: 51158 RVA: 0x002182A8 File Offset: 0x002164A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C7D7 RID: 51159 RVA: 0x002182B4 File Offset: 0x002164B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 64U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PropEntityId = input.ReadUInt32();
						}
					}
					else
					{
						this.PlaneId = input.ReadUInt32();
					}
				}
				else
				{
					this.FloorId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040050AA RID: 20650
		private static readonly MessageParser<SpringRecoverCsReq> _parser = new MessageParser<SpringRecoverCsReq>(() => new SpringRecoverCsReq());

		// Token: 0x040050AB RID: 20651
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050AC RID: 20652
		public const int FloorIdFieldNumber = 2;

		// Token: 0x040050AD RID: 20653
		private uint floorId_;

		// Token: 0x040050AE RID: 20654
		public const int PropEntityIdFieldNumber = 10;

		// Token: 0x040050AF RID: 20655
		private uint propEntityId_;

		// Token: 0x040050B0 RID: 20656
		public const int PlaneIdFieldNumber = 8;

		// Token: 0x040050B1 RID: 20657
		private uint planeId_;
	}
}
