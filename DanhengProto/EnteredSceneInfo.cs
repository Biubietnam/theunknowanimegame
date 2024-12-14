using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000441 RID: 1089
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnteredSceneInfo : IMessage<EnteredSceneInfo>, IMessage, IEquatable<EnteredSceneInfo>, IDeepCloneable<EnteredSceneInfo>, IBufferMessage
	{
		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06003058 RID: 12376 RVA: 0x00084BC8 File Offset: 0x00082DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnteredSceneInfo> Parser
		{
			get
			{
				return EnteredSceneInfo._parser;
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06003059 RID: 12377 RVA: 0x00084BCF File Offset: 0x00082DCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnteredSceneInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x0600305A RID: 12378 RVA: 0x00084BE1 File Offset: 0x00082DE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnteredSceneInfo.Descriptor;
			}
		}

		// Token: 0x0600305B RID: 12379 RVA: 0x00084BE8 File Offset: 0x00082DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnteredSceneInfo()
		{
		}

		// Token: 0x0600305C RID: 12380 RVA: 0x00084BF0 File Offset: 0x00082DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnteredSceneInfo(EnteredSceneInfo other) : this()
		{
			this.floorId_ = other.floorId_;
			this.planeId_ = other.planeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x00084C21 File Offset: 0x00082E21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnteredSceneInfo Clone()
		{
			return new EnteredSceneInfo(this);
		}

		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x0600305E RID: 12382 RVA: 0x00084C29 File Offset: 0x00082E29
		// (set) Token: 0x0600305F RID: 12383 RVA: 0x00084C31 File Offset: 0x00082E31
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

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06003060 RID: 12384 RVA: 0x00084C3A File Offset: 0x00082E3A
		// (set) Token: 0x06003061 RID: 12385 RVA: 0x00084C42 File Offset: 0x00082E42
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

		// Token: 0x06003062 RID: 12386 RVA: 0x00084C4B File Offset: 0x00082E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnteredSceneInfo);
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x00084C59 File Offset: 0x00082E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnteredSceneInfo other)
		{
			return other != null && (other == this || (this.FloorId == other.FloorId && this.PlaneId == other.PlaneId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x00084C98 File Offset: 0x00082E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FloorId != 0U)
			{
				num ^= this.FloorId.GetHashCode();
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

		// Token: 0x06003065 RID: 12389 RVA: 0x00084CF0 File Offset: 0x00082EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003066 RID: 12390 RVA: 0x00084CF8 File Offset: 0x00082EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x00084D04 File Offset: 0x00082F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FloorId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.FloorId);
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

		// Token: 0x06003068 RID: 12392 RVA: 0x00084D60 File Offset: 0x00082F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FloorId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FloorId);
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

		// Token: 0x06003069 RID: 12393 RVA: 0x00084DB8 File Offset: 0x00082FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnteredSceneInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FloorId != 0U)
			{
				this.FloorId = other.FloorId;
			}
			if (other.PlaneId != 0U)
			{
				this.PlaneId = other.PlaneId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x00084E08 File Offset: 0x00083008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600306B RID: 12395 RVA: 0x00084E14 File Offset: 0x00083014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
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
					this.FloorId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001339 RID: 4921
		private static readonly MessageParser<EnteredSceneInfo> _parser = new MessageParser<EnteredSceneInfo>(() => new EnteredSceneInfo());

		// Token: 0x0400133A RID: 4922
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400133B RID: 4923
		public const int FloorIdFieldNumber = 12;

		// Token: 0x0400133C RID: 4924
		private uint floorId_;

		// Token: 0x0400133D RID: 4925
		public const int PlaneIdFieldNumber = 13;

		// Token: 0x0400133E RID: 4926
		private uint planeId_;
	}
}
