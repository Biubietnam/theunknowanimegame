using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013E1 RID: 5089
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateMechanismBarScNotify : IMessage<UpdateMechanismBarScNotify>, IMessage, IEquatable<UpdateMechanismBarScNotify>, IDeepCloneable<UpdateMechanismBarScNotify>, IBufferMessage
	{
		// Token: 0x17003FB8 RID: 16312
		// (get) Token: 0x0600E2E3 RID: 58083 RVA: 0x0025B92F File Offset: 0x00259B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateMechanismBarScNotify> Parser
		{
			get
			{
				return UpdateMechanismBarScNotify._parser;
			}
		}

		// Token: 0x17003FB9 RID: 16313
		// (get) Token: 0x0600E2E4 RID: 58084 RVA: 0x0025B936 File Offset: 0x00259B36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateMechanismBarScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003FBA RID: 16314
		// (get) Token: 0x0600E2E5 RID: 58085 RVA: 0x0025B948 File Offset: 0x00259B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateMechanismBarScNotify.Descriptor;
			}
		}

		// Token: 0x0600E2E6 RID: 58086 RVA: 0x0025B94F File Offset: 0x00259B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMechanismBarScNotify()
		{
		}

		// Token: 0x0600E2E7 RID: 58087 RVA: 0x0025B958 File Offset: 0x00259B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMechanismBarScNotify(UpdateMechanismBarScNotify other) : this()
		{
			this.planeId_ = other.planeId_;
			this.floorId_ = other.floorId_;
			this.eAMNLINHGII_ = ((other.eAMNLINHGII_ != null) ? other.eAMNLINHGII_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E2E8 RID: 58088 RVA: 0x0025B9B0 File Offset: 0x00259BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMechanismBarScNotify Clone()
		{
			return new UpdateMechanismBarScNotify(this);
		}

		// Token: 0x17003FBB RID: 16315
		// (get) Token: 0x0600E2E9 RID: 58089 RVA: 0x0025B9B8 File Offset: 0x00259BB8
		// (set) Token: 0x0600E2EA RID: 58090 RVA: 0x0025B9C0 File Offset: 0x00259BC0
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

		// Token: 0x17003FBC RID: 16316
		// (get) Token: 0x0600E2EB RID: 58091 RVA: 0x0025B9C9 File Offset: 0x00259BC9
		// (set) Token: 0x0600E2EC RID: 58092 RVA: 0x0025B9D1 File Offset: 0x00259BD1
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

		// Token: 0x17003FBD RID: 16317
		// (get) Token: 0x0600E2ED RID: 58093 RVA: 0x0025B9DA File Offset: 0x00259BDA
		// (set) Token: 0x0600E2EE RID: 58094 RVA: 0x0025B9E2 File Offset: 0x00259BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MechanismBarInfo EAMNLINHGII
		{
			get
			{
				return this.eAMNLINHGII_;
			}
			set
			{
				this.eAMNLINHGII_ = value;
			}
		}

		// Token: 0x0600E2EF RID: 58095 RVA: 0x0025B9EB File Offset: 0x00259BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateMechanismBarScNotify);
		}

		// Token: 0x0600E2F0 RID: 58096 RVA: 0x0025B9FC File Offset: 0x00259BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateMechanismBarScNotify other)
		{
			return other != null && (other == this || (this.PlaneId == other.PlaneId && this.FloorId == other.FloorId && object.Equals(this.EAMNLINHGII, other.EAMNLINHGII) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E2F1 RID: 58097 RVA: 0x0025BA5C File Offset: 0x00259C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlaneId != 0U)
			{
				num ^= this.PlaneId.GetHashCode();
			}
			if (this.FloorId != 0U)
			{
				num ^= this.FloorId.GetHashCode();
			}
			if (this.eAMNLINHGII_ != null)
			{
				num ^= this.EAMNLINHGII.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E2F2 RID: 58098 RVA: 0x0025BACA File Offset: 0x00259CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E2F3 RID: 58099 RVA: 0x0025BAD2 File Offset: 0x00259CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E2F4 RID: 58100 RVA: 0x0025BADC File Offset: 0x00259CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FloorId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.FloorId);
			}
			if (this.eAMNLINHGII_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.EAMNLINHGII);
			}
			if (this.PlaneId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.PlaneId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E2F5 RID: 58101 RVA: 0x0025BB54 File Offset: 0x00259D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlaneId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PlaneId);
			}
			if (this.FloorId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FloorId);
			}
			if (this.eAMNLINHGII_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EAMNLINHGII);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E2F6 RID: 58102 RVA: 0x0025BBC4 File Offset: 0x00259DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateMechanismBarScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlaneId != 0U)
			{
				this.PlaneId = other.PlaneId;
			}
			if (other.FloorId != 0U)
			{
				this.FloorId = other.FloorId;
			}
			if (other.eAMNLINHGII_ != null)
			{
				if (this.eAMNLINHGII_ == null)
				{
					this.EAMNLINHGII = new MechanismBarInfo();
				}
				this.EAMNLINHGII.MergeFrom(other.EAMNLINHGII);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E2F7 RID: 58103 RVA: 0x0025BC40 File Offset: 0x00259E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E2F8 RID: 58104 RVA: 0x0025BC4C File Offset: 0x00259E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 82U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PlaneId = input.ReadUInt32();
						}
					}
					else
					{
						if (this.eAMNLINHGII_ == null)
						{
							this.EAMNLINHGII = new MechanismBarInfo();
						}
						input.ReadMessage(this.EAMNLINHGII);
					}
				}
				else
				{
					this.FloorId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005A3D RID: 23101
		private static readonly MessageParser<UpdateMechanismBarScNotify> _parser = new MessageParser<UpdateMechanismBarScNotify>(() => new UpdateMechanismBarScNotify());

		// Token: 0x04005A3E RID: 23102
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A3F RID: 23103
		public const int PlaneIdFieldNumber = 13;

		// Token: 0x04005A40 RID: 23104
		private uint planeId_;

		// Token: 0x04005A41 RID: 23105
		public const int FloorIdFieldNumber = 3;

		// Token: 0x04005A42 RID: 23106
		private uint floorId_;

		// Token: 0x04005A43 RID: 23107
		public const int EAMNLINHGIIFieldNumber = 10;

		// Token: 0x04005A44 RID: 23108
		private MechanismBarInfo eAMNLINHGII_;
	}
}
