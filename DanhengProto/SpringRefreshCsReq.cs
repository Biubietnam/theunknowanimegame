using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001185 RID: 4485
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpringRefreshCsReq : IMessage<SpringRefreshCsReq>, IMessage, IEquatable<SpringRefreshCsReq>, IDeepCloneable<SpringRefreshCsReq>, IBufferMessage
	{
		// Token: 0x17003876 RID: 14454
		// (get) Token: 0x0600C82C RID: 51244 RVA: 0x0021924D File Offset: 0x0021744D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpringRefreshCsReq> Parser
		{
			get
			{
				return SpringRefreshCsReq._parser;
			}
		}

		// Token: 0x17003877 RID: 14455
		// (get) Token: 0x0600C82D RID: 51245 RVA: 0x00219254 File Offset: 0x00217454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpringRefreshCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003878 RID: 14456
		// (get) Token: 0x0600C82E RID: 51246 RVA: 0x00219266 File Offset: 0x00217466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringRefreshCsReq.Descriptor;
			}
		}

		// Token: 0x0600C82F RID: 51247 RVA: 0x0021926D File Offset: 0x0021746D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRefreshCsReq()
		{
		}

		// Token: 0x0600C830 RID: 51248 RVA: 0x00219275 File Offset: 0x00217475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRefreshCsReq(SpringRefreshCsReq other) : this()
		{
			this.floorId_ = other.floorId_;
			this.propEntityId_ = other.propEntityId_;
			this.planeId_ = other.planeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C831 RID: 51249 RVA: 0x002192B2 File Offset: 0x002174B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringRefreshCsReq Clone()
		{
			return new SpringRefreshCsReq(this);
		}

		// Token: 0x17003879 RID: 14457
		// (get) Token: 0x0600C832 RID: 51250 RVA: 0x002192BA File Offset: 0x002174BA
		// (set) Token: 0x0600C833 RID: 51251 RVA: 0x002192C2 File Offset: 0x002174C2
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

		// Token: 0x1700387A RID: 14458
		// (get) Token: 0x0600C834 RID: 51252 RVA: 0x002192CB File Offset: 0x002174CB
		// (set) Token: 0x0600C835 RID: 51253 RVA: 0x002192D3 File Offset: 0x002174D3
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

		// Token: 0x1700387B RID: 14459
		// (get) Token: 0x0600C836 RID: 51254 RVA: 0x002192DC File Offset: 0x002174DC
		// (set) Token: 0x0600C837 RID: 51255 RVA: 0x002192E4 File Offset: 0x002174E4
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

		// Token: 0x0600C838 RID: 51256 RVA: 0x002192ED File Offset: 0x002174ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringRefreshCsReq);
		}

		// Token: 0x0600C839 RID: 51257 RVA: 0x002192FC File Offset: 0x002174FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringRefreshCsReq other)
		{
			return other != null && (other == this || (this.FloorId == other.FloorId && this.PropEntityId == other.PropEntityId && this.PlaneId == other.PlaneId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C83A RID: 51258 RVA: 0x00219358 File Offset: 0x00217558
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

		// Token: 0x0600C83B RID: 51259 RVA: 0x002193C9 File Offset: 0x002175C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C83C RID: 51260 RVA: 0x002193D1 File Offset: 0x002175D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C83D RID: 51261 RVA: 0x002193DC File Offset: 0x002175DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PropEntityId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.PropEntityId);
			}
			if (this.PlaneId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.PlaneId);
			}
			if (this.FloorId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.FloorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C83E RID: 51262 RVA: 0x00219454 File Offset: 0x00217654
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

		// Token: 0x0600C83F RID: 51263 RVA: 0x002194C4 File Offset: 0x002176C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringRefreshCsReq other)
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

		// Token: 0x0600C840 RID: 51264 RVA: 0x00219528 File Offset: 0x00217728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C841 RID: 51265 RVA: 0x00219534 File Offset: 0x00217734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 80U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.FloorId = input.ReadUInt32();
						}
					}
					else
					{
						this.PlaneId = input.ReadUInt32();
					}
				}
				else
				{
					this.PropEntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040050D4 RID: 20692
		private static readonly MessageParser<SpringRefreshCsReq> _parser = new MessageParser<SpringRefreshCsReq>(() => new SpringRefreshCsReq());

		// Token: 0x040050D5 RID: 20693
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050D6 RID: 20694
		public const int FloorIdFieldNumber = 13;

		// Token: 0x040050D7 RID: 20695
		private uint floorId_;

		// Token: 0x040050D8 RID: 20696
		public const int PropEntityIdFieldNumber = 5;

		// Token: 0x040050D9 RID: 20697
		private uint propEntityId_;

		// Token: 0x040050DA RID: 20698
		public const int PlaneIdFieldNumber = 10;

		// Token: 0x040050DB RID: 20699
		private uint planeId_;
	}
}
