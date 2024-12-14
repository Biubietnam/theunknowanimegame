using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013D5 RID: 5077
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateEnergyScNotify : IMessage<UpdateEnergyScNotify>, IMessage, IEquatable<UpdateEnergyScNotify>, IDeepCloneable<UpdateEnergyScNotify>, IBufferMessage
	{
		// Token: 0x17003F8D RID: 16269
		// (get) Token: 0x0600E24F RID: 57935 RVA: 0x00259EA1 File Offset: 0x002580A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateEnergyScNotify> Parser
		{
			get
			{
				return UpdateEnergyScNotify._parser;
			}
		}

		// Token: 0x17003F8E RID: 16270
		// (get) Token: 0x0600E250 RID: 57936 RVA: 0x00259EA8 File Offset: 0x002580A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateEnergyScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F8F RID: 16271
		// (get) Token: 0x0600E251 RID: 57937 RVA: 0x00259EBA File Offset: 0x002580BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateEnergyScNotify.Descriptor;
			}
		}

		// Token: 0x0600E252 RID: 57938 RVA: 0x00259EC1 File Offset: 0x002580C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnergyScNotify()
		{
		}

		// Token: 0x0600E253 RID: 57939 RVA: 0x00259EC9 File Offset: 0x002580C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnergyScNotify(UpdateEnergyScNotify other) : this()
		{
			this.energyInfo_ = ((other.energyInfo_ != null) ? other.energyInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E254 RID: 57940 RVA: 0x00259EFE File Offset: 0x002580FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateEnergyScNotify Clone()
		{
			return new UpdateEnergyScNotify(this);
		}

		// Token: 0x17003F90 RID: 16272
		// (get) Token: 0x0600E255 RID: 57941 RVA: 0x00259F06 File Offset: 0x00258106
		// (set) Token: 0x0600E256 RID: 57942 RVA: 0x00259F0E File Offset: 0x0025810E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RotaterEnergyInfo EnergyInfo
		{
			get
			{
				return this.energyInfo_;
			}
			set
			{
				this.energyInfo_ = value;
			}
		}

		// Token: 0x0600E257 RID: 57943 RVA: 0x00259F17 File Offset: 0x00258117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateEnergyScNotify);
		}

		// Token: 0x0600E258 RID: 57944 RVA: 0x00259F25 File Offset: 0x00258125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateEnergyScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.EnergyInfo, other.EnergyInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E259 RID: 57945 RVA: 0x00259F58 File Offset: 0x00258158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.energyInfo_ != null)
			{
				num ^= this.EnergyInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E25A RID: 57946 RVA: 0x00259F94 File Offset: 0x00258194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E25B RID: 57947 RVA: 0x00259F9C File Offset: 0x0025819C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E25C RID: 57948 RVA: 0x00259FA5 File Offset: 0x002581A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.energyInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.EnergyInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E25D RID: 57949 RVA: 0x00259FD8 File Offset: 0x002581D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.energyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EnergyInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E25E RID: 57950 RVA: 0x0025A018 File Offset: 0x00258218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateEnergyScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.energyInfo_ != null)
			{
				if (this.energyInfo_ == null)
				{
					this.EnergyInfo = new RotaterEnergyInfo();
				}
				this.EnergyInfo.MergeFrom(other.EnergyInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E25F RID: 57951 RVA: 0x0025A06C File Offset: 0x0025826C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E260 RID: 57952 RVA: 0x0025A078 File Offset: 0x00258278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.energyInfo_ == null)
					{
						this.EnergyInfo = new RotaterEnergyInfo();
					}
					input.ReadMessage(this.EnergyInfo);
				}
			}
		}

		// Token: 0x04005A01 RID: 23041
		private static readonly MessageParser<UpdateEnergyScNotify> _parser = new MessageParser<UpdateEnergyScNotify>(() => new UpdateEnergyScNotify());

		// Token: 0x04005A02 RID: 23042
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A03 RID: 23043
		public const int EnergyInfoFieldNumber = 10;

		// Token: 0x04005A04 RID: 23044
		private RotaterEnergyInfo energyInfo_;
	}
}
